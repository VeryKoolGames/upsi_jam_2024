using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFace : MonoBehaviour
{
    private bool isInFocusMode;


    public new GameObject camera;
    public FacesHandler facesHandler;
    public int id;

    void OnMouseEnter(){
        if(!isInFocusMode){
            facesHandler.DeactivateOtherFaces(id);
        }
    }
     void OnMouseExit(){
        facesHandler.DeactivateFaces();
    }


    void OnMouseDown(){
        isInFocusMode = true;
        Debug.Log("Click deteced");
        camera.SetActive(true);
    }

    void Update(){
        if(Input.GetMouseButtonDown(3) && isInFocusMode){
            camera.SetActive(false);
            isInFocusMode = false;
        }
    }
   
}
