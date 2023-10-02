using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcCollider : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.Find("UI").transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
