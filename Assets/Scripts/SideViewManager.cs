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
    [SerializeField] GameObject tdview, sview;
    private void Awake()
    {
        SetPositions();
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

    public void ToggleView()
    {
        if (tdview.activeSelf)
        {
            tdview.SetActive(false);
            sview.SetActive(true);

            CreateNewObstacle();
            ResetPositions();
        }
        else
        {
            tdview.SetActive(true);
            sview.SetActive(false);
        }
    }

}
