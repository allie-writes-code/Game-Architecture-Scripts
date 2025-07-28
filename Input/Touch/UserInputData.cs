using System;
using UnityEngine;

[CreateAssetMenu(fileName = "UserInputData", menuName = "Scriptable Objects/User Input Data", order = 1)]
public class UserInputData : ScriptableObject
{
	/* Variable non serialized to ensure it resets on restart. This can also be 
	 * done manually but as we don't need to view it in the inspector or save  
	 * it long term (i.e. save to file), this should hopefully be fine. */	
    [NonSerialized]
    public Vector2 touchPos;
}
