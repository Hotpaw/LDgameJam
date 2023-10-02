using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TramSpawner : MonoBehaviour
{
    public GameObject[] tramCarts;
    public GameObject endCart;
    Transform cartPosition;
     int cartCreatedUntilLastTram;
    public int wincountTrams;

    public float tramOffset;
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
        cartCreatedUntilLastTram++;
        if (cartCreatedUntilLastTram == wincountTrams)
        {
            int randomCart1 = Random.Range(0, tramCarts.Length);

            cartPosition = transformOfTheCard.topPosition;

            GameObject cart1 = Instantiate(endCart, cartPosition.position, Quaternion.identity);

            cart1.transform.position = new Vector2(0, cart1.transform.position.y + tramOffset);
        }
        else { 
        
        int randomCart = Random.Range(0, tramCarts.Length);

        cartPosition = transformOfTheCard.topPosition;
      
        GameObject cart = Instantiate(tramCarts[randomCart], cartPosition.position, Quaternion.identity);

        cart.transform.position = new Vector2(0, cart.transform.position.y + tramOffset);
        }
    }
}
