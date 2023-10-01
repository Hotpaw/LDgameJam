using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(Collider2D))]
public class EventOnTrigger : MonoBehaviour
{
    public UnityEvent eventOnTrigger;
    public string tag;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(tag))
        {
            eventOnTrigger.Invoke();
        }
    }
}
