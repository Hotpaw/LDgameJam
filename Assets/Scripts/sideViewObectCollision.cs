using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class sideViewObectCollision : MonoBehaviour
{
    public bool isWin;
    public SideViewManager.ObstacleType type;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player")) 
        {
            if (isWin)
                FindObjectOfType<SideViewManager>().ToggleView(type);
            else
                GameObject.Find("UI").transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
