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
        CreateFallingObjects();
    }

    private void CreateFallingObjects()
    {
        if (timer > cooldown)
        {
            int randomTransformSpawnPoint = Random.Range(0, SpawnPoints.Length);
            int randomFallingGameObject = Random.Range(0, fallingObjects.Length);

            GameObject fObject = Instantiate(fallingObjects[randomFallingGameObject], SpawnPoints[randomTransformSpawnPoint].position, Quaternion.identity);

            timer = 0;
        }
    }
}
