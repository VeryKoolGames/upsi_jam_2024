using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFace : MonoBehaviour
{
    private bool startTimer;
    private float timePressed;


    public new GameObject camera;
    public FacesHandler facesHandler;
    public int id;

    void OnMouseEnter(){
        if (!facesHandler.isInFocusMode)
        {
            facesHandler.DeactivateOtherFaces(id);
        }
    }
     void OnMouseExit()
     {
        facesHandler.DeactivateFaces();
    }
     
    void OnMouseDown()
    {
        startTimer = true;
    }

    private void OnMouseUp()
    {
        startTimer = false;
        if (timePressed < .2f)
        {
            facesHandler.isInFocusMode = true;
            camera.SetActive(true);
        }
        else
        {
            facesHandler.isInFocusMode = false;
        }
        timePressed = 0f;
    }

    void Update(){
        // if(Input.GetMouseButtonDown(3) && facesHandler.isInFocusMode){
        //     camera.SetActive(false);
        //     facesHandler.isInFocusMode = false;
        // }

        if (startTimer)
        {
            timePressed += Time.deltaTime;
        }

        if (facesHandler.isInFocusMode && Input.GetMouseButtonDown(1))
        {
            camera.SetActive(false);
            facesHandler.isInFocusMode = false;
        }
    }
   
}
