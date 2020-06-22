using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bottle : MonoBehaviour
{
   public int speed =6;
   public Moves monicaScript;
    

    
    
        
    
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D> ();
        rb.velocity = new Vector2(0,speed);
        monicaScript= GameObject.Find("monica").GetComponent<Moves>();
    }
    void OnTriggerEnter2D (Collider2D outro)
    {
        if(outro.gameObject.tag=="capitaoTag")
        {
            monicaScript.vidas --;
            


        }
    }

     void OnBecameInvisible ()
    {
        Destroy (gameObject);
    }
}
