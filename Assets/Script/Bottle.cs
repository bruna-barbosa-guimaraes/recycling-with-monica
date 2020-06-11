using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
   public int speed =6;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D> ();
        rb.velocity = new Vector2(0,speed);
    }

     void OnBecameInvisible ()
    {
        Destroy (gameObject);
    }
}
