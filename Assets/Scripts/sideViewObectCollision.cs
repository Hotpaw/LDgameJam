using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideViewObectCollision : MonoBehaviour
{
    public bool isWin;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player")) 
        {
            if (isWin)
                Debug.Log("return to topview");
            else
                Debug.Log("insant death");
        }
    }
}
