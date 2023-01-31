using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject pinkFish;

public void OnTriggerEnter2D(Collider2D collision)


    {
            if (collision.gameObject.CompareTag("finish"))
            {
                Destroy(pinkFish);
            Debug.Log("hit");
            }
        }
        

    
}
