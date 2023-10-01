using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideViewManager : MonoBehaviour
{
    GameObject obstacle;
    [SerializeField] Transform spawnpoint;

    [SerializeField] List<GameObject> obstacles;

    [SerializeField] Transform playerRoot;
    List<Vector3> positions = new List<Vector3>();
    List<Quaternion> rotations =  new List<Quaternion>();
    private void Awake()
    {
        SetPositions();
    }
    private void OnEnable()
    {
        CreateNewObstacle();
        ResetPositions();
    }

    public void CreateNewObstacle()
    {
        if(obstacle)
            Destroy(obstacle);

        obstacle = Instantiate(obstacles[Random.Range(0, obstacles.Count)], spawnpoint);
    }
    void SetPositions()
    {
        positions.Clear();
        rotations.Clear();
        foreach(Transform t in playerRoot.GetComponentsInChildren<Transform>())
        {
            positions.Add(t.position);
            rotations.Add(t.rotation);
        }
    }
    void ResetPositions()
    {
        int i = 0;
        foreach (Transform t in playerRoot.GetComponentsInChildren<Transform>())
        {
            t.position = positions[i];
            t.rotation = rotations[i];
            i++;
        }
    }

}
