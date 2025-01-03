using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace YX
{
    public class ScriptIDViewer : EditorWindow
    {
        [MenuItem("Debug/ScriptIDViewer")]
        public static void Open()
        {
            var wnd = GetWindow<ScriptIDViewer>("ScriptIDViewer");
            wnd.Show();
            wnd.minSize = new Vector2(600, 400);
            wnd.maxSize = new Vector2(600, 400);
        }

        private void Awake()
        {
            m_material = new Material(Shader.Find("Hidden/Internal-Colored"));
            m_material.hideFlags = HideFlags.HideAndDontSave;
        }

        private void OnGUI()
        {
            EditorGUILayout.BeginVertical();
            EditorGUILayout.Space();
            GetId();
            DrawLine();
            GetScriptId();
            DrawLine();
            GetAssetFromId();
            DrawLine();
            GetDllScriptId();
            EditorGUILayout.Space();
            EditorGUILayout.EndVertical();
        }

        private MonoBehaviour _mono;
        void GetId()
        {
            _mono = EditorGUILayout.ObjectField(_mono, typeof(MonoBehaviour), true) as MonoBehaviour;
            if (_mono)
            {
                string guid;
                long fid;
                var script = MonoScript.FromMonoBehaviour(_mono);
                var path = AssetDatabase.TryGetGUIDAndLocalFileIdentifier(script, out guid, out fid);
                EditorGUILayout.TextField("fileID", fid.ToString());
                EditorGUILayout.TextField("guid", guid);
            }
        }

        private MonoScript _script;
        void GetScriptId()
        {
            _script = EditorGUILayout.ObjectField(_script, typeof(MonoScript), true) as MonoScript;
            if (_script)
            {
                string guid;
                long fid;
                var path = AssetDatabase.TryGetGUIDAndLocalFileIdentifier(_script, out guid, out fid);
                EditorGUILayout.TextField("fileID", fid.ToString());
                EditorGUILayout.TextField("guid", guid);
            }
        }

        string _guid, _fid;
        string _result;
        void GetAssetFromId()
        {
            EditorGUILayout.BeginHorizontal();
            _fid = EditorGUILayout.TextField("fileID", _fid);
            _guid = EditorGUILayout.TextField("guid", _guid);
            if (GUILayout.Button("find"))
            {
                _result = "Œ¥’“µΩ";
                var path = AssetDatabase.GUIDToAssetPath(_guid);
                var assets = AssetDatabase.LoadAllAssetsAtPath(path);
                string guid;
                long fid;

                for (int i = 0; i < assets.Length; i++)
                {
                    var asset = assets[i];
                    var s = AssetDatabase.TryGetGUIDAndLocalFileIdentifier(asset, out guid, out fid);
                    if (s && _fid == fid.ToString())
                    {
                        var script = asset as MonoScript;
                        string name;
                        if (script != null)
                            name = script.GetClass().FullName;
                        else
                            name = asset.name;
                        _result = string.Format("{0}->{1}", path, name);
                        break;
                    }
                }
            }
            EditorGUILayout.EndHorizontal();
            GUILayout.TextField(_result);
        }


        private DefaultAsset _dll;
        string _dll_guid;
        long _dll_fid;
        Object[] _dllAssets;
        private float _scrollValueX = 0;
        private float _scrollValueY = 0;
        private Vector2 _scroll;
        void GetDllScriptId()
        {
            _dll = EditorGUILayout.ObjectField(".dll", _dll, typeof(DefaultAsset), true) as DefaultAsset;
            GUILayout.BeginHorizontal();
            EditorGUILayout.TextField("fileID", _dll_fid.ToString());
            EditorGUILayout.TextField("guid", _dll_guid);
            GUILayout.EndHorizontal();
            if (GUILayout.Button("Open") && _dll != null)
            {
                var path = AssetDatabase.GetAssetPath(_dll);
                if (path.EndsWith(".dll"))
                    _dllAssets = AssetDatabase.LoadAllAssetsAtPath(path);
                else
                    _dllAssets = null;
            }

            if (_dllAssets != null && _dllAssets.Length > 0)
            {
                _scroll = EditorGUILayout.BeginScrollView(_scroll, GUILayout.Width(600));
                for (int i = 0; i < _dllAssets.Length; i++)
                {
                    EditorGUILayout.BeginHorizontal();
                    GUILayout.TextField(_dllAssets[i].name);
                    if (GUILayout.Button("view", GUILayout.Width(100)))
                    {
                        var s = AssetDatabase.TryGetGUIDAndLocalFileIdentifier(_dllAssets[i], out _dll_guid, out _dll_fid);
                    }
                    EditorGUILayout.EndHorizontal();
                }
                EditorGUILayout.EndScrollView();
            }
        }

        Material m_material;
        void DrawLine()
        {
            EditorGUILayout.Space(20);
            if (Event.current.type == EventType.Repaint)
            {
                var lastRect = GUILayoutUtility.GetLastRect();
                var rect = new Rect(0, lastRect.y, 600, 20);
                GL.PushMatrix();
                m_material.SetPass(0);
                GL.LoadPixelMatrix();
                GL.Begin(GL.QUADS);
                GL.Color(new Color32(78, 201, 176, 255));
                GL.Vertex3(rect.x, rect.y, 0);
                GL.Vertex3(rect.x + rect.width, rect.y, 0);
                GL.Vertex3(rect.x + rect.width, rect.y + rect.height, 0);
                GL.Vertex3(rect.x, rect.y + rect.height, 0);
                GL.End();
                GL.PopMatrix();
            }
        }
    }
}