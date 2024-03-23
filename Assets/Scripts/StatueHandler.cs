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
    private void OnMouseDown()
    {
        statueCanvas.SetActive(true);
    }

    public void CloseCanvas()
    {
        statueCanvas.SetActive(false);
    }

    public void OnStringEntered(string input)
    {
        if (input == correctWord)
        {
            Debug.Log("Found the right word");
        }
        else
        {
            Debug.Log("Maybe warn the player he was wrong");
        }
    }
}
