using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourManager : MonoBehaviour
{
    //list of sites
    public GameObject[] objSites;
    //main menu
    public GameObject canvasMainMenu;
    //should the camera move
    public bool isCameraMove = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isCameraMove)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                ReturnToMenu();
            }
        }
    }

    public void LoadSite(int siteNumber)
    {
        //show site
        objSites[siteNumber].SetActive(true);
        //hide menu
        canvasMainMenu.SetActive(true);
        //enable the camera
        isCameraMove = true;
    }

    public void ReturnToMenu()
    {
        //show the menu
        canvasMainMenu.SetActive(true);
        //hide sites
        for(int i = 0; i < objSites.Length; i++)
        {
            objSites[i].SetActive(false);
        }

        //disable the camera
        isCameraMove = false;
    }
}
