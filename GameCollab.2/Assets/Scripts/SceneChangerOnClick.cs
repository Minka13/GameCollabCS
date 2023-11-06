using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerOnClick: MonoBehaviour
{
    public string SceneNameToLoad;

    void Start()
    {
        
    }

    void OnTriggerStay()
    {
        if(Input.GetKey(KeyCode.E))
            SceneManager.LoadScene(SceneNameToLoad);
    }

}

