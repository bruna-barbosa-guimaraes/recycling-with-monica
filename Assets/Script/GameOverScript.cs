using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverScript : MonoBehaviour
{
    void Start()
    {
     Invoke("DelayGameOver",3);   
    }
    private void DelayGameOver(){
        SceneManager.LoadScene("MenuScene");
    }
}
