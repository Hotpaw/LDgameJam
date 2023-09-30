using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puddle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<Movement>() != null)
        {
            collision.GetComponent<Movement>().deacceleration = 0;
            collision.GetComponent<Movement>().maxSpeed = 100;
            collision.GetComponent<Movement>().acceleration = 100;
        }
            
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        OnTriggerEnter2D (collision);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Movement>() != null)
        {
            collision.GetComponent<Movement>().deacceleration = 4;
            collision.GetComponent<Movement>().maxSpeed = 5;
            collision.GetComponent<Movement>().acceleration = 10;
        }
    }
}

