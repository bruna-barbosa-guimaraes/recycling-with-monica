using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CreditsScript : MonoBehaviour
{
    //botao 'back' da tela 'Credits' volta para o 'Menu'
    public void OnClickBackButton()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
