using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenVideoManager : MonoBehaviour
{
    public string levelToLoad;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Video"))
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
