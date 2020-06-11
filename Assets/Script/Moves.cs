using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{

   public GameObject garrafa;
   public int speed = 10;
   void Update() 
   {
       float horizontal = Input.GetAxis("Horizontal") * speed *Time.deltaTime;
       transform.Translate(horizontal, 0, 0); 
     

       //disparar garrafa
       if (Input.GetKeyDown(KeyCode.Space))
       {

        //spawnar bala
        Instantiate(garrafa,transform.position,Quaternion.identity);
       }
   }
}
