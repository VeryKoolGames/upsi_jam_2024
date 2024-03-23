using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Face2Slider : MonoBehaviour
{
    [SerializeField] private Animator playerAnim; // https://www.youtube.com/watch?v=JS4k_lwmZHk
    [SerializeField] private string triggerName;
    
    private Vector3 mousePosition;
    private Vector3 originalPosition;
    private bool isColliding;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();
        originalPosition = transform.position;
        GetComponent<AudioSource>().Play();
    }
    
    void OnMouseUp()
    {
        if (!isColliding)
            transform.position = originalPosition;
        GetComponent<AudioSource>().Stop();
    }

    private void OnMouseDrag()
    {
        Vector3 camPos = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
        // if (camPos.x > transform.position.x)
            
        if (gameObject.CompareTag("XSliderDown")
            && camPos.x < transform.position.x
            && !isColliding)
            transform.position = new Vector3(camPos.x, transform.position.y, transform.position.z);
        if (gameObject.CompareTag("XSliderUp")
            && camPos.x > transform.position.x
            && !isColliding)
            transform.position = new Vector3(camPos.x, transform.position.y, transform.position.z);
        if (gameObject.CompareTag("YSliderDown")
            && camPos.y < transform.position.y
            && !isColliding)
            transform.position = new Vector3(transform.position.x, camPos.y, transform.position.z);
        if (gameObject.CompareTag("YSliderUp")
            && camPos.y > transform.position.y
            && !isColliding)
            transform.position = new Vector3(transform.position.x, camPos.y, transform.position.z);
        if (gameObject.CompareTag("ZSliderDown")
            && camPos.z < transform.position.z
            && !isColliding)
            transform.position = new Vector3(transform.position.x, transform.position.y, camPos.z);
        if (gameObject.CompareTag("ZSliderUp")
            && camPos.y > transform.position.y
            && !isColliding)
            transform.position = new Vector3(transform.position.x, transform.position.y, camPos.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SliderCollider"))
        {
            isColliding = true;
            Debug.Log("Gate" + triggerName + "Up");
            playerAnim.SetBool(triggerName, true);
        }
    }
}

