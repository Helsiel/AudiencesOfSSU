using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public static int SceneNumber;

    void Start()
    {
        if(SceneNumber == 0)
        {
            StartCoroutine(ToSplashTwo());
            }
     }
    IEnumerator ToSplashTwo()
    {
        yield return new WaitForSeconds(4);
        SceneNumber = 1;
        SceneManager.LoadScene(1);
}

}
