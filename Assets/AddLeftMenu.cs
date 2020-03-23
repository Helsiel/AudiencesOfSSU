using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddLeftMenu : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject MenuNavigation;
    public bool IfPause=false;

    
    void Update()
    {
        if (IfPause)
        {
            Pause();
        }
        else if (!IfPause)
        {
            Resume();
        }
    }

    public void Pause()
    {
        PauseMenu.SetActive(false);
        MenuNavigation.SetActive(true);
        IfPause = true;
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        PauseMenu.SetActive(true);
        MenuNavigation.SetActive(false);
        IfPause = false;
        Time.timeScale = 1f;
    }
    public void Exit()
    {
        Application.Quit();
    }
   

}
