using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartTransforms : MonoBehaviour
{
    public Transform topPosition;
    public Transform middlePosition;
    public Transform bottomPosition;
     TramSpawner tramSpawner;

    bool nextCardSpawned = false;
    private void Start()
    {
        tramSpawner = FindObjectOfType<TramSpawner>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Movement>() != null)
        {
            
            if (!nextCardSpawned)
            {
                nextCardSpawned = true;
                tramSpawner.CreateNewCart(this);
            }
        }
    }
}
