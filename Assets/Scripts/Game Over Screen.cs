using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{

    private void OnEnable()
    {
        Time.timeScale = 0;
    }
    public void unfreeze()
    {
        Time.timeScale = 1;
    }
}
