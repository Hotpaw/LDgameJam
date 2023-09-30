using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   
    Scene scene;  

    private void Start()
    {
      scene =  SceneManager.GetActiveScene();
    }

    public void ChangeLevel(string type)
    {
        switch (type)
        {
            case "start":
                SceneManager.LoadScene(1, LoadSceneMode.Single);
                break;
            case "menu":
                SceneManager.LoadScene(0, LoadSceneMode.Single);
                break;
            case "exit": Application.Quit();
                break;
            case "restart":
                SceneManager.LoadScene(scene.buildIndex, LoadSceneMode.Single);
                break;
        }
    }
}
