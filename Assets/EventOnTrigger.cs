using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(Collider2D))]
public class EventOnTrigger : MonoBehaviour
{
    public UnityEvent eventOnTrigger;
    public string tag
}
