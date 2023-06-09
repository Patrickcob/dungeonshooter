using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="RoomNodeType_", menuName ="Scriptable Objects/Dungeon/Room Node Type")]
public class RoomNodeTypeSO : ScriptableObject
{
    public string roomNodeTypeName;

    //enum?
    //remove headers lol

    #region Header
    [Header("Only flag the RoomNodeTypes that should be visible in the editor")]
    #endregion Header
    public bool isDisplayInNodeGraphEditor = true;

    #region Header
    [Header("One type should be a corridor")]
    #endregion Header
    public bool isCorridor;

    #region Header
    [Header("One type should be a corridorNS")]
    #endregion Header
    public bool isCorridorNS;

    #region Header
    [Header("One type should be a corridorEW")]
    #endregion Header
    public bool isCorridorEW;

    #region Header
    [Header("One type should be an Entrance")]
    #endregion Header
    public bool isEntrance;

    #region Header
    [Header("One type should be a boss room")]
    #endregion Header
    public bool isBossRoom;

    #region Header
    [Header("One type should be unassigned")]
    #endregion Header
    public bool isNone;
}
