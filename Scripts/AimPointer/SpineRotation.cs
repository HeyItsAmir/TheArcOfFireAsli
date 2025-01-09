using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpineRotation : MonoBehaviour
{
    public Transform UpperBody;
    public Transform AimPointer;
    //public Transform Player;
    public float RotationSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AimPointer != null && UpperBody != null)
        {
            Vector3 AimDirection = AimPointer.position - UpperBody.position;
            
            AimDirection.y = 0f;

            if (AimDirection != Vector3.zero)
            {
            Debug.Log("UpperBody");
                Quaternion targetRotation = Quaternion.LookRotation(AimDirection);

                UpperBody.rotation = Quaternion.Lerp(UpperBody.rotation, targetRotation, Time.deltaTime * RotationSpeed);
            }
        }
    }
}
