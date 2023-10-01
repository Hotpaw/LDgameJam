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

    Vector2 movePos;
    Vector2 startPos;

    public float moveFreq;
    public float moveDis;
    private void Start()
    {
        tramSpawner = FindObjectOfType<TramSpawner>();
        startPos = transform.position;
      
    }
    private void Update()
    {
        movePos.x = startPos.x + Mathf.Sin(Time.time * moveFreq) * moveDis;
        transform.position = new Vector2(movePos.x, transform.position.y);
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
