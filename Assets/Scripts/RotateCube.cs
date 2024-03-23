using System;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float PCRotationSpeed = 10f;
    public float MobileRotationSpeed = 0.4f;
    public Transform cubeTransform;
    public FacesHandler facesHandler;

    public Camera cam;

    private void OnMouseDrag()
    {
        facesHandler.DeactivateFaces();
        facesHandler.isInFocusMode = true;
        float rotx = Input.GetAxis("Mouse X") * PCRotationSpeed;
        float roty = Input.GetAxis("Mouse Y") * PCRotationSpeed;
        
        Vector3 right = Vector3.Cross(cam.transform.up, cubeTransform.position - cam.transform.position);
        Vector3 up = Vector3.Cross( cubeTransform.position - cam.transform.position, right);
        cubeTransform.rotation = Quaternion.AngleAxis(-rotx, up) * cubeTransform.rotation;
        cubeTransform.rotation = Quaternion.AngleAxis(roty, right) * cubeTransform.rotation;
    }

    private void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            Ray camRay = cam.ScreenPointToRay(touch.position);
            RaycastHit raycastHit;
            if (Physics.Raycast(camRay, out raycastHit, 10))
            {
                if (touch.phase == TouchPhase.Moved)
                {
                    cubeTransform.Rotate(touch.deltaPosition.y * MobileRotationSpeed, -touch.deltaPosition.x * MobileRotationSpeed, 0, Space.World);
                }
            }
        }
    }
}