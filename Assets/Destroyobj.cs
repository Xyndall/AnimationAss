using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyobj : MonoBehaviour
{

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Tree")
        {
            Destroy(collision.gameObject);
        }
    }
}
