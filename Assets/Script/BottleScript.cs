using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BottleScript : MonoBehaviour
{
   public int speed =6;
   public MonicaScript monicaScript;
   private PointsScript ptScript;
   void Start()
   {
        Rigidbody2D rb = GetComponent<Rigidbody2D> ();
        rb.velocity = new Vector2(0,speed);
        monicaScript= GameObject.Find("Monica").GetComponent<MonicaScript>();
        ptScript= GameObject.Find("Score").GetComponent<PointsScript>();
   }
   void OnTriggerEnter2D (Collider2D outro)
   {
        if(outro.gameObject.tag=="capitaoTag")
        {
            monicaScript.vidas --;
            Destroy (gameObject);
        }
        if(outro.gameObject.tag=="Trash10")
        {
            ptScript.pontos +=10;
            Destroy (gameObject);
        }
        if(outro.gameObject.tag=="Trash20")
        {
            ptScript.pontos +=20;
            Destroy (gameObject);
        }
        if(outro.gameObject.tag=="Trash30")
        {
            ptScript.pontos +=30;
            Destroy (gameObject);
        }
   }
   void OnBecameInvisible ()
   {
        Destroy (gameObject);
   }
}
