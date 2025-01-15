using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Animator animator;
    public RotationJoystick RightJoystick;

    private bool isShooting = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (RightJoystick.InputVector == Vector2.zero && !isShooting)
        {
            isShooting = true;
            TriggerShootingAnimation();
        }
        if (RightJoystick.InputVector != Vector2.zero) 
        {
            isShooting = false;
        }
    }
    void TriggerShootingAnimation () 
    {
        animator.SetTrigger("Shoot");
        Debug.Log("shooting Animation Triggered");
    }
}
