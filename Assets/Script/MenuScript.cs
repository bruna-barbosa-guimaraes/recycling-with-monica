using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    void Update()
    {
       if(Input.GetKey("escape"))
       {
           Application.Quit();
       } 
    }
    public void OnClickStartGame()//ao clicar em start ele inicia o game
    {
        SceneManager.LoadScene("GameScene");
    }
    public void OnClickCredits()
    {
         SceneManager.LoadScene("CreditsScene");//carrega a cena de creditos
    }
    public void OnClickExitGame()//sai do jogo
    {
        Application.Quit();
    }
}
