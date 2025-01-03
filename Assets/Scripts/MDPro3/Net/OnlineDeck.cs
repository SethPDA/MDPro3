using MDPro3.YGOSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using MDPro3.Utility;

namespace MDPro3.Net
{
    public static class OnlineDeck
    {
        public static OnlineDeckData[] decks;

        #region Const
        const string url = "http://rarnu.xyz:38383";
        const string liteAPI = "/api/mdpro3/deck/list/lite";
        const string getAPI = "/api/mdpro3/deck/";
        const string likeAPI = "/api/mdpro3/deck/like/";

        const string getAllAPI = "/api/mdpro3/sync/";
        const string syncAllAPI = "/api/mdpro3/sync/multi";
        const string getIdsAPI = "/api/mdpro3/deck/deckIds?count=";
        const string getIdAPI = "/api/mdpro3/deck/deckId";
        const string syncSigleAPI = "/api/mdpro3/sync/single";
        const string publicAPI = "/api/mdpro3/deck/public";

        const string reqHeader = "ReqSource";
        const string reqValue = "MDPro3";
        const string contentTypeHeader = "Content-Type";
        const string jsonHeader = "application/json";
        const string tokenHeader = "token";
        #endregion

        #region Online Get
        public static async Task<OnlineDeckData[]> FetchSimpleDeckList(int size, string keyWord = "", string contributor = "", bool sortLike = true)
        {
            string apiUrl = url + liteAPI + $"?size={size}&keyWord={keyWord}&contributor={contributor}&sortLike={sortLike}";
            using UnityWebRequest request = UnityWebRequest.Get(apiUrl);
            request.SetRequestHeader(reqHeader, reqValue);

            try
            {
                var send = request.SendWebRequest();
                await TaskUtility.WaitUntil(() => send.isDone);
                if(!Application.isPlaying)
                    return null;

                if (request.result == UnityWebRequest.Result.Success)
                {
                    string jsonResult = request.downloadHandler.text;
                    var responseData = JsonUtility.FromJson<ResponseMultiSimpleData>(request.downloadHandler.text);
                    return responseData.data;
                }
                else
                {
                    MessageManager.Cast("FetchSimpleDeckList Error : " + request.error);
                    return null;
                }
            }
            catch(Exception e)
            {
                Debug.Log("FetchSimpleDeckList Error: " + e);
                return null;
            }
            finally
            {
                request.Dispose();
                if(request.downloadHandler != null)
                    request.downloadHandler.Dispose();
            }
        }
        public static async Task<OnlineDeckData> GetDeck(string deckID)
        {
            string apiUrl = url + getAPI + deckID;
            using UnityWebRequest request = UnityWebRequest.Get(apiUrl);
            request.SetRequestHeader(reqHeader, reqValue);

            try
            {
                var send = request.SendWebRequest();
                await TaskUtility.WaitUntil(() => send.isDone);
                if(!Application.isPlaying)
                    return null;

                if (request.result == UnityWebRequest.Result.Success)
                {
                    return JsonUtility.FromJson<ResponseSingleData>(request.downloadHandler.text).data;
                }
                else
                {
                    MessageManager.Cast("FetchSimpleDeckList Error: " + request.error);
                    return null;
                }
            }
            catch (Exception e)
            {
                Debug.Log("FetchSimpleDeckList Error: " + e);
                return null;
            }
            finally
            {
                request.Dispose();
                if (request.downloadHandler != null)
                    request.downloadHandler.Dispose();
            }
        }
        public static async Task<OnlineDeckData[]> GetAllDecks()
        {
            if (MyCard.account == null)
                return null;

            int userId = MyCard.account.user.id;
            string apiUrl = url + getAllAPI + userId;

            using UnityWebRequest request = UnityWebRequest.Get(apiUrl);
            request.SetRequestHeader(reqHeader, reqValue);
            request.SetRequestHeader(tokenHeader, MyCard.account.token);

            var send = request.SendWebRequest();
            await TaskUtility.WaitUntil(() => send.isDone);
            if (!Application.isPlaying)
                return null;

            if (request.result == UnityWebRequest.Result.Success)
            {
                decks = JsonUtility.FromJson<ResponseMultiSimpleData>(request.downloadHandler.text).data;
                return decks;
            }
            else
            {
                MessageManager.Cast(InterString.Get("获取MyCard卡组失败：") + request.error);
                return null;
            }
        }
        public static async void LikeDeck(string deckId)
        {
            string apiUrl = url + likeAPI + deckId;

            using UnityWebRequest request = UnityWebRequest.PostWwwForm(apiUrl, jsonHeader);
            request.SetRequestHeader(reqHeader, reqValue);
            request.SetRequestHeader(contentTypeHeader, jsonHeader);
            
            var send = request.SendWebRequest();
            await TaskUtility.WaitUntil(() => send.isDone);
            if (!Application.isPlaying)
                return;

            if (request.result == UnityWebRequest.Result.Success)
            {
                var responseData = JsonUtility.FromJson<ResponseSingleData>(request.downloadHandler.text);
                if (responseData.code == 0)
                    MessageManager.Cast(InterString.Get("点赞卡组成功。"));
                else
                    MessageManager.Cast(InterString.Get("点赞卡组失败：") + InterString.Get(responseData.message, responseData.messageValue));
            }
            else
                MessageManager.Cast(InterString.Get("点赞卡组失败：") + request.error);
        }
        #endregion

        #region Online Post
        public static async Task<bool> UploadDecks(List<Deck> decks, List<string> deckNames)
        {
            string apiUrl = url + getIdsAPI + decks.Count;
            using var getIDs = UnityWebRequest.Get(apiUrl);
            getIDs.SetRequestHeader(reqHeader, reqValue);

            var send = getIDs.SendWebRequest();
            await TaskUtility.WaitUntil(() => send.isDone);
            if(!Application.isPlaying)
                return false;

            string[] ids;
            if (getIDs.result == UnityWebRequest.Result.Success)
            {
                var responseData = JsonUtility.FromJson<ResponseDeckIDs>(getIDs.downloadHandler.text);
                ids = responseData.data;
            }
            else
            {
                MessageManager.Cast(InterString.Get("上传卡组失败：") + getIDs.error);
                return false;
            }

            apiUrl = url + syncAllAPI;
            var body = new PostAllDecksBody();
            body.deckContributor = MyCard.account.user.username;
            body.userId = MyCard.account.user.id;
            body.decks = new PostDeck[decks.Count];
            for (int i = 0; i < decks.Count; i++)
            {
                var oldName = deckNames[i];
                var newName = deckNames[i];
                if (DeckNameExist(oldName))
                {
                    newName += " - " + InterString.Get("复制");
                    while (File.Exists(Program.deckPath + newName + Program.ydkExpansion))
                        newName += " - " + InterString.Get("复制");
                    File.Delete(Program.deckPath + oldName + Program.ydkExpansion);
                }

                body.decks[i] = new PostDeck();
                body.decks[i].deckId = ids[i];
                body.decks[i].deckName = newName;
                body.decks[i].deckCoverCard1 = decks[i].Pickup.Count > 0 ? decks[i].Pickup[0] : 0;
                body.decks[i].deckCoverCard2 = decks[i].Pickup.Count > 1 ? decks[i].Pickup[1] : 0;
                body.decks[i].deckCoverCard3 = decks[i].Pickup.Count > 2 ? decks[i].Pickup[2] : 0;
                body.decks[i].deckCase = decks[i].Case;
                body.decks[i].deckProtector = decks[i].Protector;
                body.decks[i].isDelete = false;
                body.decks[i].deckYdk = decks[i].GetYDK();

                decks[i].deckId = ids[i];
                decks[i].userId = MyCard.account.user.id.ToString();
                decks[i].Save(newName, DateTime.Now, false);
            }

            var json = JsonUtility.ToJson(body);
            using UnityWebRequest request = UnityWebRequest.Post(apiUrl, json, jsonHeader);

            request.SetRequestHeader(reqHeader, reqValue);
            request.SetRequestHeader(contentTypeHeader, jsonHeader);
            request.SetRequestHeader(tokenHeader, MyCard.account.token);

            send = request.SendWebRequest();
            await TaskUtility.WaitUntil(() => send.isDone);
            if (!Application.isPlaying)
                return false;

            if (request.result == UnityWebRequest.Result.Success)
            {
#if UNITY_EDITOR
                var responseData = JsonUtility.FromJson<ResponseMultiData>(request.downloadHandler.text);
                Debug.Log(string.Format("Deck Upload: {0}/{1}", responseData.data, decks.Count));
#endif
                await GetAllDecks();
                return true;
            }
            else
            {
                MessageManager.Cast(InterString.Get("上传卡组失败：") + request.error);
                return false;
            }
        }

        public static async Task<bool> SyncDeck(string deckId, string deckName, Deck deck, bool showHint = true)
        {
            //Debug.Log("Sync Deck: " + deckName);
            deck.deckId = deckId;
            deck.userId = MyCard.account.user.id.ToString();
            var ydk = deck.GetYDK();

            var od = GetByID(deckId);
            if (od == null || od.isDelete)
                return await UploadDecks(new List<Deck> { deck }, new List<string> { deckName });

            od.deckYdk = ydk;
            od.deckName = deckName;
            string apiUrl = url + syncSigleAPI;
            var body = new PostDeckBody
            {
                userId = MyCard.account.user.id,
                deckContributor = MyCard.account.user.username,
                deck = new PostDeck(deck, deckId, deckName, ydk)
            };

            var json = JsonUtility.ToJson(body);
            using var request = UnityWebRequest.Post(apiUrl, json, jsonHeader);
            request.SetRequestHeader(reqHeader, reqValue);
            request.SetRequestHeader(contentTypeHeader, jsonHeader);
            request.SetRequestHeader(tokenHeader, MyCard.account.token);

            //Debug.LogFormat("{0}, {1}", MyCard.account.user.id, deckId);
            var send = request.SendWebRequest();
            await TaskUtility.WaitUntil(() => send.isDone);
            if (!Application.isPlaying)
                return false;

            if (request.result == UnityWebRequest.Result.Success)
            {
                var responseData = JsonUtility.FromJson<SyncResponseSingleData>(request.downloadHandler.text);
                Debug.LogFormat("Sync Deck: {0}, Result: {1} {2} {3}.", deckName, responseData.code, responseData.message, responseData.data);
                if (showHint)
                    MessageManager.Cast(InterString.Get("云端卡组「[?]」已同步。", deckName));
                deck.Save(deckName, DateTime.Now, false);
                return true;
            }
            else
            {
                MessageManager.Cast(InterString.Get("云端卡组同步失败：") + request.error);
                return false;
            }
        }

        public static async Task<bool> DeleteDecks(List<string> ids)
        {
            if (ids == null || ids.Count == 0)
                return false;

            var toDelete = new List<string>();
            foreach (var id in ids)
                foreach (var deck in decks)
                    if (deck.deckId == id)
                    {
                        toDelete.Add(id);
                        deck.isDelete = true;
                    }

            var apiUrl = url + syncAllAPI;
            var body = new PostAllDecksBody();
            body.deckContributor = MyCard.account.user.username;
            body.userId = MyCard.account.user.id;
            body.decks = new PostDeck[toDelete.Count];
            for (int i = 0; i < toDelete.Count; i++)
            {
                body.decks[i] = new PostDeck();
                body.decks[i].deckId = toDelete[i];
                body.decks[i].isDelete = true;
            }

            var json = JsonUtility.ToJson(body);
            using UnityWebRequest request = UnityWebRequest.Post(apiUrl, json, jsonHeader);

            request.SetRequestHeader(reqHeader, reqValue);
            request.SetRequestHeader(contentTypeHeader, jsonHeader);
            request.SetRequestHeader(tokenHeader, MyCard.account.token);

            var send = request.SendWebRequest();
            await TaskUtility.WaitUntil(() => send.isDone);
            if (!Application.isPlaying)
                return false;

            if (request.result == UnityWebRequest.Result.Success)
            {
                //MessageManager.Cast(InterString.Get("云端卡组删除成功"));
#if UNITY_EDITOR
                var responseData = JsonUtility.FromJson<ResponseMultiData>(request.downloadHandler.text);
                MessageManager.Cast(string.Format("Deck Delete: {0}/{1}", responseData.data, ids.Count));
#endif
                await GetAllDecks();
                return true;
            }
            else
            {
                MessageManager.Cast(InterString.Get("删除云端卡组失败：") + request.error);
                return false;
            }
        }
        public static async Task<bool> UpdatePublicState(string deckId, bool isPublic)
        {
            var apiUrl = url + publicAPI;
            var body = new PostPublicBody
            {
                deckId = deckId,
                isPublic = isPublic,
                userId = MyCard.account.user.id
            };

            var json = JsonUtility.ToJson(body);
            using var request = UnityWebRequest.Post(apiUrl, json, jsonHeader);
            request.SetRequestHeader(reqHeader, reqValue);
            request.SetRequestHeader(contentTypeHeader, jsonHeader);
            request.SetRequestHeader(tokenHeader, MyCard.account.token);

            var send = request.SendWebRequest();
            await TaskUtility.WaitUntil(() => send.isDone);
            if(!Application.isPlaying)
                return false;

            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("UpdatePublicState Success: " + isPublic);
                return true;
            }
            else
            {
                Debug.Log("UpdatePublicState Failed: " + request.error);
                return false;
            }
        }

        #endregion

        #region Functions
        public static OnlineDeckData GetByID(string deckId)
        {
            if (decks == null)
                return null;
            foreach (var deck in decks)
                if (deck.deckId == deckId)
                    return deck;
            return null;
        }
        public static bool GetDeckPublicState(string deckId)
        {
            if (decks == null)
                return false;
            foreach(var deck in decks)
                if(deck.deckId == deckId)
                    return deck.isPublic;
            return false;
        }
        public static bool StringIsIdFormat(string deckId)
        {
            return !string.IsNullOrEmpty(deckId);
            if (deckId.Length != 10)
                return false;
            if (!Tools.StringIsLowerAlphaNumeric(deckId))
                return false;
            return true;
        }
        private static bool DeckNameExist(string deckName)
        {
            if (decks == null)
                return false;
            foreach (var deck in decks)
                if (deck.deckName == deckName && !deck.isDelete)
                    return true;
            return false;
        }

        #endregion

        #region Structure

        [Serializable]
        public class OnlineDeckData
        {
            public string deckId;
            public string deckContributor;
            public string deckName;
            public int deckRank = 0;
            public int deckLike = 0;
            public string deckUploadDate;
            public string deckUpdateDate;
            public int deckCoverCard1 = 0;
            public int deckCoverCard2 = 0;
            public int deckCoverCard3 = 0;
            public int deckCase = 0;
            public int deckProtector = 0;
            public string lastDate;
            public string deckYdk;
            public string deckMainSerial;
            public int userid;
            public bool isPublic;
            public string description;
            public bool isDelete;

            public OnlineDeckData() { }

            public DateTime GetUpdateTime()
            {
                try
                {
                    return DateTime.Parse(deckUpdateDate);
                }
                catch
                {
                    return DateTime.Parse(deckUploadDate);
                }
            }
        }

        [Serializable]
        public class ResponseSingleData
        {
            public int code = 0;
            public string message;
            public string messageValue;
            public OnlineDeckData data;
        }

        [Serializable]
        public class ResponseMultiData
        {
            public int code = 0;
            public string message;
            public int data;
        }

        [Serializable]
        public class SyncResponseSingleData
        {
            public int code;
            public string message;
            public bool data;
        }
        [Serializable]
        public class ResponseMultiSimpleData
        {
            public int code = 0;
            public string message;
            public string messageValue;
            public OnlineDeckData[] data;
        }

        [Serializable]
        public class ResponseRecords
        {
            public int current;
            public int size;
            public int total;
            public int pages;
            public OnlineDeckData[] records;
        }
        [Serializable]
        public class ResponseDeckID
        {
            public int code;
            public int message;
            public string data;
        }
        [Serializable]
        public class ResponseDeckIDs
        {
            public int code;
            public int message;
            public string[] data;
        }

        [Serializable]
        public class PostAllDecksBody
        {
            public string deckContributor;
            public int userId;
            public PostDeck[] decks;
        }

        [Serializable]
        public class PostDeckBody
        {
            public string deckContributor;
            public int userId;
            public PostDeck deck;
        }

        [Serializable]
        public class PostDeck
        {
            public string deckId;
            public string deckName;
            public int deckCoverCard1;
            public int deckCoverCard2;
            public int deckCoverCard3;
            public int deckCase;
            public int deckProtector;
            public string deckYdk;
            public bool isDelete;

            public PostDeck()
            {
            }

            public PostDeck(Deck deck, string deckId, string deckName, string ydk)
            {
                this.deckId = deckId;
                this.deckName = deckName;
                if(deck.Pickup.Count > 0)
                    deckCoverCard1 = deck.Pickup[0];
                if (deck.Pickup.Count > 1)
                    deckCoverCard1 = deck.Pickup[1];
                if (deck.Pickup.Count > 2)
                    deckCoverCard1 = deck.Pickup[2];
                deckCase = deck.Case;
                deckProtector = deck.Protector;
                deckYdk = ydk;
                isDelete = false;
            }
        }

        [Serializable]
        public class PostPublicBody
        {
            public int userId;
            public string deckId;
            public bool isPublic;
        }
        #endregion
    }
}
