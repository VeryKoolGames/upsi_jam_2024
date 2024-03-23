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
    [SerializeField] private SelectFacesManager _selectFacesManager;
    public int id;

    void OnMouseEnter(){
        if (!InputManager.Instance.inputEnabled) return;
        if (!facesHandler.isInFocusMode)
        {
            facesHandler.DeactivateOtherFaces(id);
        }
    }
     void OnMouseExit()
     {
         if (!InputManager.Instance.inputEnabled) return;

        facesHandler.DeactivateFaces();
    }
     
    void OnMouseDown()
    {
        if (!InputManager.Instance.inputEnabled) return;
        startTimer = true;
    }

    private void OnMouseUp()
    {
        if (!InputManager.Instance.inputEnabled) return;
        startTimer = false;
        if (timePressed < .2f)
        {
            camera.SetActive(true);
            facesHandler.DeactivateColliders();
            _selectFacesManager.ActivateFace(id);
            StartCoroutine(delayFocusMode(true));
        }
        else
        {
            facesHandler.isInFocusMode = false;
        }
        timePressed = 0f;
    }

    void Update(){
        if (!InputManager.Instance.inputEnabled) return;
        if (startTimer)
        {
            timePressed += Time.deltaTime;
        }

        if (facesHandler.isInFocusMode && Input.GetMouseButtonDown(1))
        {
            camera.SetActive(false);
            facesHandler.ReactivateColliders();
            _selectFacesManager.DeactivateFace(id);
            StartCoroutine(delayFocusMode(false));
            facesHandler.DeactivateOtherFaces(id);
        }
    }

    IEnumerator delayFocusMode(bool isFocus)
    {
        yield return new WaitForSeconds(1f);
        facesHandler.isInFocusMode = isFocus;
    }
   
}
