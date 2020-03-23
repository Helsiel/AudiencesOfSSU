using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadMap1 : MonoBehaviour
{
    public string sceneName;
    public Button playButton;

    void Start()
    {
        playButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}
