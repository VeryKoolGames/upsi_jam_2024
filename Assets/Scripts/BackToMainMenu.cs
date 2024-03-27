using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackToMainMenu : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(waitForCutscene());
    }

    IEnumerator waitForCutscene(){
        yield return new WaitForSeconds(21);
        SceneManager.LoadScene(0);
    }
}
