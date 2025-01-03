using UnityEngine;

namespace MDPro3
{
    [CreateAssetMenu]
    public class DuelPrefabContainer : ScriptableObject
    {
        [Header("Duel Prefabs")]
        public GameObject cardModel;
        public GameObject duelButton;
        public GameObject duelLpText;
        public GameObject duelChatItemMe;
        public GameObject duelChatItemOp;

        [Header("Duel Phase")]
        public GameObject duelDrawPhaseNear;
        public GameObject duelDrawPhaseFar;
        public GameObject duelStandbyPhaseNear;
        public GameObject duelStandbyPhaseFar;
        public GameObject duelMain1PhaseNear;
        public GameObject duelMain1PhaseFar;
        public GameObject duelBattlePhaseNear;
        public GameObject duelBattlePhaseFar;
        public GameObject duelMain2PhaseNear;
        public GameObject duelMain2PhaseFar;
        public GameObject duelEndPhaseNear;
        public GameObject duelEndPhaseFar;
        [Header("Duel Turn Change")]
        public GameObject duelTurnChangeNear;
        public GameObject duelTurnChangeFar;
        [Header("Duel Log")]
        public GameObject duelLogNewTurn;
        public GameObject duelLogNewPhase;
        public GameObject duelLogSingleCard;
        public GameObject duelLogSingleCard2;
        public GameObject duelLogAttack;
        public GameObject duelLogChaining;
        public GameObject duelLogText;
        public GameObject duelLogText2;
        public GameObject duelLogTextWithCard;
        public GameObject duelLogTextWithCard2;
        public GameObject duelLogLpChange;
        public GameObject duelLogCounter;
    }
}
