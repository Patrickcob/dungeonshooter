using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Game.RoomEditorWindow
{
    public class RoomNodeGraphEditor : EditorWindow
    {
        private const float nodeWidth = 160f;
        private const float nodeHeight = 75f;
        private const int nodePadding = 25;
        private const int nodeBorder = 12;

        private GUIStyle m_nodeStyle;

        [MenuItem("Room node Graph Editor", menuItem ="Window/Dungeon Editor/Room Node Graph Editor")]
        private static void OpenWindow()
        {
            GetWindow<RoomNodeGraphEditor>("Room node Graph Editor");
        }

        private void OnEnable()
        {
            m_nodeStyle = new GUIStyle();
            m_nodeStyle.normal.background = EditorGUIUtility.Load("node1") as Texture2D;
            m_nodeStyle.normal.textColor = Color.white;
            m_nodeStyle.padding = new RectOffset(nodePadding, nodePadding, nodePadding, nodePadding);
            m_nodeStyle.border = new RectOffset(nodeBorder, nodeBorder, nodeBorder, nodeBorder);
        }

        private void OnGUI()
        {
            GUILayout.BeginArea(new Rect(new Vector2(100f, 100f), new Vector2(nodeWidth, nodeHeight)), m_nodeStyle);
            EditorGUILayout.LabelField("Node 1");
            GUILayout.EndArea();
        }
    }

}
