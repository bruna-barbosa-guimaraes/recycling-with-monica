using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    void Update()
    {
       //se clicar tecla 'Esc' sai do jogo
       if(Input.GetKey("escape"))
       {
           Application.Quit();
       } 
    }
    //ao clicar em start ele inicia o game
    public void OnClickStartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    //carrega a cena de creditos
    public void OnClickCredits()
    {
         SceneManager.LoadScene("CreditsScene");
    }
    //sai do jogo
    public void OnClickExitGame()
    {
        Application.Quit();
    }
}
