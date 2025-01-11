using UnityEngine;



public class JoystickPlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public MovementJoystick MovmentJoystick;
    public Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        Vector2 input = MovmentJoystick.InputVector;

        Vector3 moveDirection = new Vector3(input.x, 0, input.y);
        Vector3 targetPosition = rb.position + moveDirection * speed * Time.fixedDeltaTime;
        rb.MovePosition(targetPosition);

        if (moveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveDirection);
            rb.MovePosition(targetPosition);
        }
    }
}


        //if (variableJoystick.Horizontal == 0 && variableJoystick.Vertical == 0)
        //{
        //    rb.velocity = Vector3.zero;
        //}
        //Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        //rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        //    }
        //}
