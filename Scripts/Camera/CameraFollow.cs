using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private PlayerMovement move;
    public Transform target;
    public Vector3 Offset;
    public float Height;
    public float SmoothSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        move = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {

        Offset = new Vector3(Offset.x, Offset.y + Height, Offset.z);
        Vector3 desirePosition = target.position + Offset;
        Vector3 SmoothedPosition = Vector3.Lerp(transform.position, desirePosition, SmoothSpeed);
        transform.position = SmoothedPosition;
    }
}
