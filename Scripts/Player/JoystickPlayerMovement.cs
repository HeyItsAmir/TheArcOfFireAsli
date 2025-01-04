using UnityEngine;



public class JoystickPlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        float horizontal = variableJoystick.Horizontal;
        float vertical = variableJoystick.Vertical;

        Vector3 direction = new Vector3(horizontal, 0, vertical);

        rb.velocity = direction * speed;
        Debug.Log($"Horizontal: {horizontal}, Vertical: {vertical}");
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
