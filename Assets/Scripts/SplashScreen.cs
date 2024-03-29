using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public float waitFor;
    public float waitForSound;
    public AudioSource AudioSource;

    void Start()
    {
        StartCoroutine(WaitForStart());
        StartCoroutine(WaitForSound());
    }

    IEnumerator WaitForStart()
    {
        yield return new WaitForSeconds(waitFor);
        SceneManager.LoadScene(1);
    }

    IEnumerator WaitForSound(){
        yield return new WaitForSeconds(waitForSound);
        AudioSource.Play();
    }
    
}
