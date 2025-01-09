using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;
    //public JoystickPlayerMovement Character;
    public MovementJoystick movmentJoystick;
    public RotationJoystick rotationJoystick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = movmentJoystick.InputVector.x;
        float vertical = movmentJoystick.InputVector.y;

        float CharacterSpeed = new Vector2(movmentJoystick.InputVector.x, movmentJoystick.InputVector.y).magnitude;

        animator.SetLayerWeight(1, rotationJoystick.InputVector != Vector2.zero ? 1 : 0);

        float aimHorizontal = rotationJoystick.InputVector.x;
        float aimVertical = rotationJoystick.InputVector.y;

        //float AimingFloat = rotationJoystick.InputVector.x;

        animator.SetFloat("Speed", CharacterSpeed);
        //animator.SetFloat("AimingFloat", AimingFloat);
        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vetical", vertical);
        //Debug.Log($"AimingFloat: {AimingFloat}, InputVector: {rotationJoystick.InputVector}");
    }
}
