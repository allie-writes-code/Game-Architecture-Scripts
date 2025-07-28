using System;
using UnityEngine;

[CreateAssetMenu(fileName = "UserInputData", menuName = "Scriptable Objects/User Input Data", order = 1)]
public class UserInputData : ScriptableObject
{
    [NonSerialized]
    public Vector2 touchPos;
}
