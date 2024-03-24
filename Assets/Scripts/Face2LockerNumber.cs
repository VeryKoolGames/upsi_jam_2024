using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face2LockerNumber : MonoBehaviour
{
    [SerializeField] private Sprite[] SpriteListNum09 = new Sprite[10];
    [SerializeField] private GameObject PHUp;
    [SerializeField] private GameObject PHDown;
    [SerializeField] private GameObject numObj;
    private int num = 0;
    private GameObject player;
    // numbers : https://opengameart.org/content/numbers-0-9-7x10px
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("BodyPlayer");
    }

    public void numPlus()
    {
        if (num == 9)
            num = 0;
        else
            num++;
        numObj.GetComponent<SpriteRenderer>().sprite = SpriteListNum09[num];
        player.gameObject.GetComponent<Face2Player>().checkLockerCode();
    }
    
    public void numMinus()
    {
        if (num == 0)
            num = 9;
        else
            num--;
        numObj.GetComponent<SpriteRenderer>().sprite = SpriteListNum09[num];
        player.gameObject.GetComponent<Face2Player>().checkLockerCode();
    }

    public int getNum()
    {
        return num;
    }
}
