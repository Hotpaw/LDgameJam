using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject beerBullet;
    public GameObject spilledBeer;
    public float speed;
    public Transform target;
    public float miniumDistance;
    public float timeBetweenShots;
    private float nextShotTime;

    void Update()
    {
        if(Time.time > nextShotTime)
        {
            Instantiate(beerBullet,transform.position, Quaternion.identity);
            Instantiate(spilledBeer, transform.position, Quaternion.identity);
            nextShotTime = Time.time + timeBetweenShots;
        }
        //if (Vector2.Distance(transform.position, target.position) < miniumDistance)
        //{
        //    transform.position =  Vector2.MoveTowards(transform.position, target.position, -speed *Time.deltaTime);
        //}
        
    }
}
