using UnityEngine;
using UnityEngine.Events;

/* This class allows us to create public variables that can be subscribed to
 * and 'monitored' from other classes. */

[CreateAssetMenu(fileName = "NewSharedInt", menuName = "Shared Variables/Int")]
public class SharedInt : ScriptableObject
{
    private int _myValue;
    public int myValue
    {
        get { return _myValue; }
        set { if (_myValue != value)
            {
                _myValue = value;
                VariableChanged();
            }
        }
    }

    // UnityAction is used as a delegate that other scripts / functions can subscribe to.
    public UnityAction OnChangeRaised;

    public void VariableChanged()
    {
        OnChangeRaised?.Invoke();
    }
}
