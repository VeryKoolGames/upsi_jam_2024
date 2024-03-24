using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFace4 : MonoBehaviour
{
    [SerializeField] private GameObject canvasFace4;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("PLAYER DETECTED");
        if (other.CompareTag("Player"))
        {
            StartCoroutine(activateCanvas());
        }
    }


    IEnumerator activateCanvas()
    {
        canvasFace4.SetActive(true);
        yield return new WaitForSeconds(16f);
        canvasFace4.SetActive(false);
    }
}
