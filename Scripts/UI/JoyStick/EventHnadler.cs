//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.EventSystems;

//public class EventHandler : MonoBehaviour, IDragHandler, IPointerUpHandler
//{
//    public Vector2 InputDirection { get; private set; }

//    public void OnDrag(PointerEventData eventData)
//    {
//        Vector2 pos;
//        RectTransformUtility.ScreenPointToLocalPointInRectangle(
//            GetComponent<RectTransform>(),
//            eventData.position,
//            eventData.pressEventCamera,
//            out pos);

//        // Normalize joystick movement
//        InputDirection = pos.magnitude > 1 ? pos.normalized : pos;
//        Debug.Log("Dragging: " + InputDirection);
//    }

//    public void OnPointerUp(PointerEventData eventData)
//    {
//        InputDirection = Vector2.zero; // Reset when released
//        Debug.Log("Released joystick");
//    }
//}
