using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollidedWith : MonoBehaviour
{
    public GameObject enterText;
    void Start()
    {
        enterText.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        enterText.SetActive(true);
        if(other.name == "Parliment")
        { 
            if (Input.GetButtonDown("Use"))
            {
                SceneManager.LoadScene(2);
            }
            Debug.Log("Open Parliment 360 Picture");
        }else if(other.name == "ChainBridge")
        {
            if (Input.GetButtonDown("Use"))
            {
                SceneManager.LoadScene(3);
            }
            Debug.Log("Open ChainBridge 360 Picture");
        }
        else if(other.name == "BudaCastle")
        {
            if (Input.GetButtonDown("Use"))
            {
                SceneManager.LoadScene(4);
            }
            Debug.Log("Open BudaCastle 360 Picture");
        }
        else
        {
            if (Input.GetButtonDown("Use"))
            {
                SceneManager.LoadScene(5);
            }
            Debug.Log("Open Fisherman 360 Picture");
        }
    }
    void OnTriggerExit(Collider plyr)
    {
        enterText.SetActive(false);
    }
    
}
