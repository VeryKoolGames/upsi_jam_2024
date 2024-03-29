using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{

    public Animator animator;
    
    void Start()
    {
        animator.SetTrigger("End");
    }


}
