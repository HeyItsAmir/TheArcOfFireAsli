using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;
    public JoystickPlayerMovement Character;
    public VariableJoystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;
        float CharacterSpeed = new Vector2(horizontal, vertical).magnitude;

        

        animator.SetFloat("Speed", CharacterSpeed);
        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vetical", vertical);
    }
}
