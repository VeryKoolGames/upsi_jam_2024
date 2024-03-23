using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face2Player : MonoBehaviour
{
    private GameObject _locker;

    void Start()
    {
        _locker = GameObject.FindGameObjectWithTag("Locker");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("F2Finish"))
            _locker.transform.position = new Vector3(_locker.transform.position.x, _locker.transform.position.y, -1f);
    }
}
