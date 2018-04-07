using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderDestroyer : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.tag == "Stone")
        {
            DestroyObject(collision.gameObject);
        }
    }

}
