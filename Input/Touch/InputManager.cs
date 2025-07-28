using UnityEngine;
// Required for Touch input.
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    // Create and drag in a UserInputData SO.
    [SerializeField]
    private UserInputData inputData;

    private Touch inputTouch;
    private Vector3 touchScreenPos;
    private Vector3 touchWorldPos;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            /* Takes the touch input, if detected, gets a screen position
             * converts to a world position then feeds the final Vector3
             * to the attached UserInputData and stores it for use elsewhere. */
            
            inputTouch = Input.GetTouch(0);
            touchScreenPos = new Vector3(inputTouch.position.x, inputTouch.position.y, 0);
            touchWorldPos = Camera.main.ScreenToWorldPoint(touchScreenPos);

            inputData.touchPos = new Vector2(touchWorldPos.x, touchWorldPos.y);
        }
    }
}
