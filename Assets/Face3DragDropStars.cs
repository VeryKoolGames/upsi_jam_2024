using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face3DragDropStars : MonoBehaviour
{
    private Vector3 mousePosition;
    private bool isColliding;
    private bool isDragging;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        Debug.Log("You touch " + transform.name);
        mousePosition = Input.mousePosition - GetMousePos();
    }

    private void OnMouseDrag()
    {
        isDragging = true;
        Vector3 camPos = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
        transform.position = new Vector3(camPos.x, transform.position.y, camPos.z);
    }

    public bool getIsDragging()
    {
        return isDragging;
    }
    
    private void OnMouseUp()
    {
        isDragging = false;
    }
}
