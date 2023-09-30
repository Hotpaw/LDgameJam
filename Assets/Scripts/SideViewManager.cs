using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideViewManager : MonoBehaviour
{
    GameObject obstacle;
    [SerializeField] Transform spawnpoint;

    [SerializeField] List<GameObject> obstacles;
    private void OnEnable()
    {
        CreateNewObstacle();
    }

    public void ReturnToTopDown()
    {

    }
    public void CreateNewObstacle()
    {
        if(obstacle)
            Destroy(obstacle);

        obstacle = Instantiate(obstacles[Random.Range(0, obstacles.Count)], spawnpoint);
    }
}
