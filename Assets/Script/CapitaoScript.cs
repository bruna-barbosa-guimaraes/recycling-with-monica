using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapitaoScript : MonoBehaviour
{
   public int speed= 5;
    void Start()
    {    
         Rigidbody2D rb = GetComponent<Rigidbody2D> ();
         if(transform.position.x==-10)
         {
              rb.velocity = new Vector2 (-speed,0);
         }
         else 
         {
             rb.velocity = new Vector2 (speed,0);
         }
        
          Destroy (gameObject,5);
    }
    

}
