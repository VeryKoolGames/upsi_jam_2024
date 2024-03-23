using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face2LockerNumber : MonoBehaviour
{
    [SerializeField] private Sprite[] SpriteListNum09 = new Sprite[10];
    private GameObject[] PH = new GameObject[2];
    // numbers : https://opengameart.org/content/numbers-0-9-7x10px
    
    // Start is called before the first frame update
    void Start()
    {
        PH[0] = transform.GetChild(0).gameObject; //PHUp
        PH[1] = transform.GetChild(1).gameObject; //PHDown
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
