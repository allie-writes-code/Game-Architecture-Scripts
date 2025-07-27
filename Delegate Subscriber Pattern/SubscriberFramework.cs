/* Framework code for subscribing to an event on a sharewd variable. */

using UnityEngine;

public class SubscriberFramework : MonoBehaviour
{
    [SerializeField]
    private SharedInt sharedInt;

    private void OnEnable()
    {
        sharedInt.OnChangeRaised += SharedChange;
    }

    private void OnDisable()
    {
        sharedInt.OnChangeRaised -= SharedChange;
    }

    private void SharedChange()
    {
        Debug.Log("Variable change detected, new var is: " + sharedInt.myValue);
    }
}
