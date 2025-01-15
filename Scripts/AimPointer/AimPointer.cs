using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AimPointer : MonoBehaviour
{
    public RotationJoystick Rotationjoystick;
    public GameObject AimPointerObject;
    public Transform player;
    public float AimDistance = 10f;
    public Animator animator;
    //public Vector3 lastDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = Rotationjoystick.InputVector;
        if  (input != Vector2.zero)
        {
            if (!AimPointerObject.activeSelf)
            {
                AimPointerObject.SetActive(true);
                print("AimObject now enable");
            }


            Vector3 AimDirection = new Vector3(input.x, 0, input.y).normalized;
            //lastDirection = AimDirection;
            Vector3 targePosition = player.position + AimDirection * AimDistance;

            AimPointerObject.transform.position = targePosition;

            AimPointerObject.transform.rotation = Quaternion.LookRotation(AimDirection);

            Vector3 playerForward = player.forward;
            // ADRTP = Aim Direction Relative To The Player
            Vector3 ADRTP = (targePosition - player.position).normalized;

            float   RealtiveAngle = Vector3.SignedAngle(playerForward, ADRTP, Vector3.up);
            float normalizedAngle = Mathf.Clamp(RealtiveAngle/ 90f, -1f, 1f);
            animator.SetFloat("AimingFloat", normalizedAngle);

        }
        else
        {
            if (AimPointerObject.activeSelf)
            {
                AimPointerObject.SetActive(false);
                //print("AimObject now disable");

                //float horizontalValue = CalculateHorizontalValue(lastDirection);
                //Debug.Log($"Horizontal Value: {horizontalValue}");
                //animator.SetFloat("AimingFloat", horizontalValue);
            }
        }
    }
    private float CalculateHorizontalValue(Vector3 AimDirection)
    {
        Vector3 playerRight = player.right;
        float horizontalValue = Vector3.Dot(AimDirection, playerRight);
        return Mathf.Clamp(horizontalValue, -1, -1);
    }
}
