using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CutscenetoGameIntro : MonoBehaviour
{
    [SerializeField]
    public float DelayBeforeLoading;

    [SerializeField]
    public string SceneNameToLoad;

    public float TimeElapsed;



    private void Update()
    {
        TimeElapsed += Time.deltaTime;

        if(TimeElapsed > DelayBeforeLoading)
        {
            SceneManager.LoadScene(SceneNameToLoad);
        }
    }
}
