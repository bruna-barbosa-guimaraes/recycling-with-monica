using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MonicaScript : MonoBehaviour
{

   public GameObject Bottle;
   public int speed = 10;
   public int vidas = 3;
   public Text vidasUI;
   public Animator monica;
   
   


   void Start()
   {
        monica = GetComponent<Animator>();
        

   }
   
   
   void Update() 
   {
       SpawnGarrafa();
       Move();
       PreventLeavingScreen();
       vidasUI.text = "Vidas:" + vidas;
        if(vidas==0)
        { 
            
            Destroy(this.gameObject);
            SceneManager.LoadScene("GameOverScene");
        }
       
    }

    
  
    void SpawnGarrafa()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(Bottle,new Vector2(transform.position.x -0.2f,transform.position.y +0.7f),Quaternion.identity);
            
        }

    }

    void Move()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            
            float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            transform.Translate(horizontal, 0, 0);

            monica.SetBool("move", true);
        }
            
        else
        {
            
            monica.SetBool("move", false);
        }

        
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



