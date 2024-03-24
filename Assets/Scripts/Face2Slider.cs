using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Face2Slider : MonoBehaviour
{
    [SerializeField] private Animator playerAnim; // https://www.youtube.com/watch?v=JS4k_lwmZHk
    [SerializeField] private string triggerName;
    
    private GameObject parent;
    private bool hasClicked;

    void Start()
    {
        parent = transform.parent.gameObject;
    }

    void Update()
    {
        if (!hasClicked) return;
        transform.position = Vector3.MoveTowards(transform.position, parent.transform.GetChild(1).transform.position, Time.deltaTime * 0.05f);
    }


    private void OnMouseDown()
    {
        hasClicked = true;
        GetComponent<AudioSource>().Play();
        Debug.Log(parent.transform.GetChild(1).name);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SliderCollider"))
        {
            Debug.Log("Gate" + triggerName + "Up");
            playerAnim.SetBool(triggerName, true);
        }
    }
}

