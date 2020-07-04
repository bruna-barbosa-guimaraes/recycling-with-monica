using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class MonicaScript : MonoBehaviour
{
   public GameObject Bottle; //objeto garrafa
   public int speed = 10; //velocidade monica
   public int vidas = 3; //quantidade de vidas
   public Text vidasUI; //texto de vidas
   public Animator monica; //animacao da monica
 
   void Start()
   {
        monica = GetComponent<Animator>(); //animacao
   }
   
   void Update() //modularizacao
   {
       SpawnGarrafa();
       Move();
       PreventLeavingScreen();
       Lifes();
   }
   void SpawnGarrafa() //spawna a garrafa do meio da monica apertando espaco 
   {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bottle,new Vector2(transform.position.x -0.2f,transform.position.y +0.7f),Quaternion.identity);
        }
   }
    void Move()//movimentacao da monica 
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
           float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
           transform.Translate(horizontal, 0, 0);

           Vector3 monicaScale = transform.localScale;  
           if(horizontal>0)//rotacao da monica
           {
                monicaScale.x = 1; 
           }
           if(horizontal<0)//rotacao da monica
           {
                monicaScale.x = -1;
           }
           transform.localScale = monicaScale;
           monica.SetBool("move", true);//animacao da monica parada e andando
        }   
        else
        {
            monica.SetBool("move", false);
        }
    }
    void PreventLeavingScreen() //n deixar a monica sair da tela
    {
       if(transform.position.x <= -6.9f || transform.position.x >= 6.9f)
       {
           float PosX = Mathf.Clamp (transform.position.x,-6.9f,6.9f);
           transform.position = new Vector2(PosX,transform.position.y);
       }
    }
    void Lifes()//vidas da monica,se chegar em 0 a monica morre
    {
        vidasUI.text = "Vidas:" + vidas;
       if(vidas<=0)
       {  
            Destroy(this.gameObject);
            SceneManager.LoadScene("GameOverScene");//carrega a cena de game over
       }
    }
}



