using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadMap1 : MonoBehaviour
{
    public string sceneName1;
    public string sceneName2;
    public Button playButton;

    public Toggle Toggle2d, Toggle3d;
    protected string UnBuild = "N";
    protected int Aud = 102;
 

    void Start()
    {

        playButton.onClick.AddListener(TaskOnClick);
    }



    void TaskOnClick()
    {
        if (Toggle2d.isOn)
        {
                      SceneManager.LoadScene(sceneName1);  
                        
        }else if (Toggle3d.isOn)
        {
                        SceneManager.LoadScene(sceneName2);

        }
    }
    public Text fText;
    public void setget()
    {
        fText.text = "Audience " + Aud;
    }
}
