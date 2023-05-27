using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="RoomNodeGraph", menuName ="Scriptable Objects/Dungeon/Room Node Graph")]
public class RoomNodeGraphSO : ScriptableObject
{
    [HideInInspector] public RoomNodeTypeListSO roomNodeTypeListSO;
    [HideInInspector] public List<RoomNodeGraphSO> roomNodes;
    [HideInInspector] public Dictionary<string, RoomNodeGraphSO> roomNodesDictionary = new Dictionary<string, RoomNodeGraphSO> ();
}
