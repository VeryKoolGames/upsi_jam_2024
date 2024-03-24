using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStatuesHandler : MonoBehaviour
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
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SliderCollider"))
        {
            playerAnim.SetBool(triggerName, true);
        }
    }
}
