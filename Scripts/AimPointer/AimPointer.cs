using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimPointer : MonoBehaviour
{
    public RotationJoystick Rotationjoystick;
    public GameObject AimPointerObject;
    public Transform player;
    public float AimDistance = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = Rotationjoystick.InputVector;
        if  (Rotationjoystick.InputVector != Vector2.zero)
        {
            if (!AimPointerObject.activeSelf)
            {
                AimPointerObject.SetActive(true);
                print("AimObject now enable");
            }
            Vector3 AimDirection = new Vector3(input.x, 0, input.y).normalized;
            Vector3 targePosition = player.position + AimDirection * AimDistance;

            AimPointerObject.transform.position = targePosition;

            AimPointerObject.transform.rotation = Quaternion.LookRotation(AimDirection);
        }
        else
        {
            if (AimPointerObject.activeSelf)
            {
                AimPointerObject.SetActive(false);
                print("AimObject now disable");
            }
        }
    }
}
