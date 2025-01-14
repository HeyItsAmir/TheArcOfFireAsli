using Unity.VisualScripting;
using UnityEngine;

public class ObjectDetectionSystem : MonoBehaviour
{
    public GameObject touchedObject;

    private void OnTriggerEnter(Collider collision)
    {
        touchedObject = collision.gameObject;
    }

    private void OnTriggerExit(Collider collision)
    {
        if(collision == touchedObject.GetComponent<Collider>())
        {
            touchedObject = null;
        }
    }
    
}
