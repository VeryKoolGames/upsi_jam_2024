using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using TMPro;
using Unity.VisualScripting;

public class CubeNavigation : MonoBehaviour
{
    public GameObject[] VClist;
    public GameObject[] Faces;
    public GameObject[] FacesOverlays;
    

    void Start(){
    }
   
  
    void Update()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100) && hit.collider.CompareTag("face"))
            {
                outlineFace();
                print(hit.transform.name);
                
                for (int i = 0; i < Faces.Length; i++)
                {
                    if (Faces[i].name != hit.transform.name)
                    {
                        Faces[i].SetActive(false);
                        VClist[i].SetActive(false);
                    }
                }
                foreach (var face in Faces)
                {
                    if (face.name != hit.transform.name)
                        face.SetActive(false);
                        
                } 

            }
            else{
                foreach (var face in Faces)
                {
                    face.SetActive(true);
                } 
            }

        

    }

    void outlineFace(){
        
    }
}


    