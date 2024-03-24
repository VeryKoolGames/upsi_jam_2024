using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face3DragDropStars : MonoBehaviour
{
    private Vector3 mousePosition;
    private bool isColliding;
    private bool isDragging;
    private GameObject plane;

    private void Start()
    {
        plane = GameObject.FindGameObjectWithTag("F3Plane");
    }
    

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
        // Vector3 camPos = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
        // transform.position = new Vector3(camPos.x, transform.position.y, camPos.z);
        
        // true way to move along plane https://forum.unity.com/threads/dragging-objects-on-a-plane.5485/
        var dragPlane = new Plane(plane.transform.up, plane.transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float enter;

        if (dragPlane.Raycast(ray, out enter))
        {
            //Get the point that is clicked
            Vector3 hitPoint = ray.GetPoint(enter);

            //Move your cube GameObject to the point where you clicked
            transform.position = hitPoint;
        }
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
