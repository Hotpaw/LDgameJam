using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegPart : MonoBehaviour
{
    [SerializeField]Transform refFollow;

    Rigidbody2D rb;

    public bool isEnabled = false;

    public bool doX;
    public bool doY;

    float xIn;
    float yIn;

    public float speed = 7;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {

        if(doY)
            yIn = Input.GetAxis("Vertical");
        if (doX)
            xIn = Input.GetAxis("Horizontal");
    }
    void FixedUpdate()
    {
        if ((refFollow.position - transform.position).magnitude > 3)
            return;
        
        Vector3 move = refFollow.transform.right * yIn * xIn * speed;

        //if (doY)
          //   rb.velocity = (refFollow.transform.right*yIn*speed);
        //if(doX)
          //   rb.velocity = (refFollow.transform.right * xIn*speed);


    }
}
