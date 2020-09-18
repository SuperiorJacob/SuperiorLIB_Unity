using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 6.0F;
    public float jumpSpeed = 100.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    public Joystick joystick = null;

    private float xPos = 0f;
    private float yPos = 0f;

    public bool canMove = false;
    
    void Update()
    {
        if (!canMove)
        {
            CharacterController controller = GetComponent<CharacterController>();
            xPos += joystick != null ? joystick.Horizontal : Input.GetAxisRaw("Horizontal");
            yPos += joystick != null ? joystick.Vertical : Input.GetAxisRaw("Vertical");

            moveDirection = transform.forward;
            moveDirection = moveDirection * yPos;

            moveDirection.y -= gravity * Time.deltaTime;

            controller.Move(moveDirection * speed * Time.deltaTime);

            transform.Rotate(0, xPos, 0);

            xPos = 0;
            yPos = 0;
        }
    }
}
