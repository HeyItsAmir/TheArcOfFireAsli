using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerJoystickRotation : MonoBehaviour
{
    public VariableJoystick VariableJoystick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        float horizontal = VariableJoystick.Horizontal;
        float vertical = VariableJoystick.Vertical;

        Debug.Log($"Horizontal: {horizontal}, Vertical: {vertical}");
        if (horizontal != 0 || vertical != 0)
        {
            Vector3 lookDirection = new Vector3(horizontal,0,vertical);

            Quaternion targetRotation = Quaternion.LookRotation(lookDirection);

            transform.rotation = targetRotation;
        }
    }
}
