using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{

   public GameObject garrafa;
   public int speed = 10;
   
   
   void Update() 
   {
       SpawnGarrafa();
       Move();
       PreventLeavingScreen();
       
       
    }
  
    void SpawnGarrafa()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(garrafa,new Vector2(transform.position.x -0.2f,transform.position.y +0.7f),Quaternion.identity);
            
        }

    }

    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed *Time.deltaTime;
        transform.Translate(horizontal, 0, 0);
    }

    void PreventLeavingScreen()
    {
     
       if(transform.position.x <= -6.9f || transform.position.x >= 6.9f)

       {
           float PosX = Mathf.Clamp (transform.position.x,-6.9f,6.9f);
           transform.position = new Vector2(PosX,transform.position.y);
       }
    }

}



