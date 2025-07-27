/*
 * This is just an example to test / show the pattern working.
 * Attach this to a scene object and update the int in the inspector.
 * Ensure you've set the exampleInt by dragging in a created SO.
 */

using UnityEngine;

public class PublisherExample : MonoBehaviour
{
    [SerializeField]
    private int updateThisInteger = 0;

    public SharedInt exampleInt;

    private void Update()
    {
        if (exampleInt.myValue != updateThisInteger) exampleInt.myValue = updateThisInteger;
    }
}
