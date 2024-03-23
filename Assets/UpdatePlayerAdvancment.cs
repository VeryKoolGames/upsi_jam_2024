using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePlayerAdvancment : MonoBehaviour
{
    [SerializeField]
    private SelectFacesManager _selectFacesManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _selectFacesManager.currentPlayerState++;
        }
    }
}
