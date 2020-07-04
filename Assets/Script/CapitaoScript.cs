using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CapitaoScript : MonoBehaviour
{
    public int speed= 5; //velocidade
    
    //velocidade e rotação do inimigo 
    void Start()   
    {    
        Rigidbody2D rb = GetComponent<Rigidbody2D> ();
        //se spawna no lado esquerdo
        if(transform.position.x==-10) 
        {
            //movimenta para direita
            rb.velocity = new Vector2 (-speed,0); 
        }
        //se spawna no lado direito
        else
        {
            //movimenta para esquerda
            rb.velocity = new Vector2 (speed,0);
            //rotação da sprite
            transform.rotation = Quaternion.Euler (0, 180,0); 
        }
        //destroi depois de 5 segundos  
        Destroy(gameObject,5); 
    }
}
