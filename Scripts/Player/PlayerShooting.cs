using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
        if (RightJoystick.RightJoystickReleased == true)
        {
            isShooting = true;          
            TriggerShootingAnimation();
        }
        else if (RightJoystick.RightJoystickReleased == false) 
        {
            isShooting = false;
            TriggerShootingAnimation();
        }
    }
    void TriggerShootingAnimation () 
    {
        animator.SetBool("Shooting", isShooting);
        Debug.Log("shooting Animation Triggered");
    }
}
