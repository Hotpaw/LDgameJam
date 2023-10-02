using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winCart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.Find("UI").transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
