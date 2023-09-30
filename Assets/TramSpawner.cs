using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TramSpawner : MonoBehaviour
{
    public GameObject[] tramCarts;
    Transform cartPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CreateNewCart(CartTransforms transformOfTheCard)
    {
        int randomCart = Random.Range(0, tramCarts.Length);

        cartPosition = transformOfTheCard.topPosition;
      
        GameObject cart = Instantiate(tramCarts[randomCart], cartPosition.position, Quaternion.identity);

        cart.transform.position = new Vector2(0, cart.transform.position.y +19f);
    }
}
