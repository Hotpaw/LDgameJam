using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepsoundplayer : MonoBehaviour
{

    private void Start()
    {
        Invoke(nameof(playsfx), .3f);
    }
    void playsfx()
    {
        GetComponent<AudioSource>().pitch = Random.Range(.8f, 1.2f);
        GetComponent<AudioSource>().Play();

        Invoke(nameof(playsfx), Random.Range(.2f,1f));
    }
}
