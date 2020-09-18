using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class XboxCursor : MonoBehaviour
{
    public Vector3 originalPosition; //Original Position stored for "Start at Center position" Cursor behavior
    private Vector3 startPos;
    public float sensitivity = 10f;
    private Vector3 oldMousePos; // For making sure the original mouse isnt moving.

    public Button[] buttons;

    void Start()
    {
        transform.position = originalPosition; //Wrong method for reset to center position...
        oldMousePos = Input.mousePosition;
    }

    void Update()
    {
        if (oldMousePos != Input.mousePosition)
        {
            oldMousePos = Input.mousePosition;
            startPos = Input.mousePosition;
        }

        // Joystick Axis Acting
        Vector3 inputDirection = Vector3.zero * sensitivity;
        inputDirection.x = Input.GetAxisRaw("Horizontal") * 0.1f;
        inputDirection.y = Input.GetAxisRaw("Vertical") * 0.1f;
        transform.position = startPos + inputDirection * sensitivity;
        startPos = transform.position;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, 0f, 1920f),
                        Mathf.Clamp(transform.position.y, 0f, 1080f), transform.position.z);
    }
}