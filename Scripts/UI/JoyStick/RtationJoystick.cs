using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotationJoystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    public RectTransform joystickBackground;
    public RectTransform joystickHandle;
    private Vector2 inputVector;
    public bool RightJoystickReleased;
    public Vector2 InputVector => inputVector;

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            joystickBackground,
            eventData.position,
            eventData.pressEventCamera,
            out pos);

        pos /= joystickBackground.sizeDelta;

         
        inputVector = pos.magnitude > 1.0f ? pos.normalized : pos;

         
        joystickHandle.anchoredPosition = new Vector2(
            inputVector.x * (joystickBackground.sizeDelta.x / 2),
            inputVector.y * (joystickBackground.sizeDelta.y / 2)
        );
        //Debug.Log($"Joystick Handle Position: {joystickHandle.anchoredPosition}, InputVector: {inputVector}");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        inputVector = Vector2.zero;
        joystickHandle.anchoredPosition = Vector2.zero;
        Debug.Log("Shoot");      
        RightJoystickReleased = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Joystick Pressed");
        OnDrag(eventData);       
        RightJoystickReleased = false;
    }
}
