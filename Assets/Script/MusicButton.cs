using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicButton : MonoBehaviour
{
    public GameObject Music;
    int start = 0;
    void Start()
    {
        Music.SetActive(false);
    }
    void Update()
    {
        if (Input.GetButtonDown("Music"))
        {
            if(start == 0 )
            { 
                Music.SetActive(true);
                start = 1;
            }
            else
            {
                Music.SetActive(false);
                start = 0;
            }
            
        }
    }
}
