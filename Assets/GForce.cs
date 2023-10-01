using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GForce : MonoBehaviour
{
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Push(Vector2 dir, float force)
    {
        if(CompareTag("Player"))
        {
            var movecs = GetComponent<Movement>();

            movecs.ExternalForceToggle();

            movecs.ExternalForce(dir * force);

            movecs.Invoke(nameof(movecs.ExternalForceToggle), 1.5f);
        }

        rb.AddForce(dir * force, ForceMode2D.Impulse);
    }
}
