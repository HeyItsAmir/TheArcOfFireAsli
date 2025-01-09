using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerJoystickRotation : MonoBehaviour
{
    public RotationJoystick rightJoystick; 
    public Transform playerBody;
    public Animator animator; 

    void Update()
    {
        
        Vector2 input = rightJoystick.InputVector;

        float aimingFloat = Mathf.Clamp(input.x, -1f, 1f);

        animator.SetFloat("AimingFloat", aimingFloat);

        //Debug.Log($"Joystick Input: {input}, AimingFloat: {aimingFloat}");
    }
}
