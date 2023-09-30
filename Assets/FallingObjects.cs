using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FallingObjects : MonoBehaviour
{
    public GameObject[] fallingObjects;
    public Transform[] SpawnPoints;
    float timer;
    public float cooldown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > cooldown)
        {
            int random = Random.Range(0, SpawnPoints.Length);
            GameObject fObject = Instantiate(gameObject, SpawnPoints[random].position, Quaternion.identity);
        }
    }
}
