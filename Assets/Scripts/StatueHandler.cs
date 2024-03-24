using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject statueCanvas;
    [SerializeField]
    private string correctWord;
    [SerializeField]
    private Animator statueAnimator;
    [SerializeField]
    private Animator playerAnim;

    private bool isCanvasActive;
    private void OnMouseDown()
    {
        if (isCanvasActive)
        {
            statueCanvas.SetActive(false);
            isCanvasActive = false;
        }
        else
        {
            statueCanvas.SetActive(true);
            isCanvasActive = true;
        }
    }

    public void CloseCanvas()
    {
        statueCanvas.SetActive(false);
    }

    public void OnStringEntered(string input)
    {
        if (input == correctWord)
        {
            statueAnimator.SetTrigger("moveChaman");
            CloseCanvas();
            StartCoroutine(StartPlayerAnim());
        }
        else
        {
            Debug.Log("Maybe warn the player he was wrong");
        }
    }

    IEnumerator StartPlayerAnim()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(2f);
        GetComponent<AudioSource>().Stop();
        playerAnim.SetBool("F5G1", value:true);
    }
}
