using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face2Player : MonoBehaviour
{
    private GameObject _locker;
    private string lockerNum1;
    private string lockerNum2;
    private string lockerNum3;

    void Start()
    {
        _locker = GameObject.FindGameObjectWithTag("Locker");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("F2Finish")) // when player at finish, show locker
        {
            _locker.transform.position = new Vector3(0, 0, -8);
        }
    }

    public void checkLockerCode()
    {
        lockerNum1 = _locker.transform.GetChild(0).GetComponentInChildren<Face2LockerNumber>().getNum().ToString();
        lockerNum2 = _locker.transform.GetChild(1).GetComponentInChildren<Face2LockerNumber>().getNum().ToString();
        lockerNum3 = _locker.transform.GetChild(2).GetComponentInChildren<Face2LockerNumber>().getNum().ToString();
        if (lockerNum1 + lockerNum2 + lockerNum3 == "357")
            Debug.Log("FACE 2 COMPLETED, CONGRATS 🎉");
    }
}
