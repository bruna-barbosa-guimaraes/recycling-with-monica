using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BottleScript : MonoBehaviour
{
   public int speed =6; //velocidade
   public MonicaScript monicaScript; //script da Monica
   private PointsScript ptScript; //script dos pontos
   void Start()
   {
        MoveBottle();
   }
   //funcao das colisoes
   void OnTriggerEnter2D (Collider2D outro)
   {
        if(outro.gameObject.tag=="capitaoTag")//se a garrafa tocar no capitao feio uma vida é perdida
        {
            monicaScript.vidas --;
            Destroy (gameObject);
        }
        if(outro.gameObject.tag=="Trash10")//se tocar no lixo10 é acumulado 10 pontos
        {
            ptScript.pontos +=10;
            Destroy (gameObject);
        }
        if(outro.gameObject.tag=="Trash20")//se tocar no lixo20 é acumulado 20 pontos
        {
            ptScript.pontos +=20;
            Destroy (gameObject);
        }
        if(outro.gameObject.tag=="Trash30")//se tocar no lixo30 é acumulado 30 pontos
        {
            ptScript.pontos +=30;
            Destroy (gameObject);
        }
   }
   //ao sair da tela ele se auto destroi
   void OnBecameInvisible () 
   {
        Destroy (gameObject);
   }
   //movimentacao da garrafa
   void MoveBottle()
   {
       Rigidbody2D rb = GetComponent<Rigidbody2D> ();
       rb.velocity = new Vector2(0,speed);
       monicaScript= GameObject.Find("Monica").GetComponent<MonicaScript>();//ele procura o scrpit da monica para associar os pontos e score
       ptScript= GameObject.Find("Score").GetComponent<PointsScript>();
   }
}
