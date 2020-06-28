using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     Invoke("DelayGameOver",3);   
    }

    private void DelayGameOver(){
        SceneManager.LoadScene("MenuScene");
    }
}
