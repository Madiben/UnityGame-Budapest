using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{

    public void doExitGame()
    {
        Application.Quit();
    }
    public void doStartGame()
    {
        SceneManager.LoadScene(1);
    }
}
