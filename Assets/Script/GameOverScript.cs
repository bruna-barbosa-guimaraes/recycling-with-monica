using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverScript : MonoBehaviour
{
    //apos 3 segundos da tela de game over é carregado a tela de menu
    void Start()
    {
     Invoke("DelayGameOver",3);   
    }
    private void DelayGameOver()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
