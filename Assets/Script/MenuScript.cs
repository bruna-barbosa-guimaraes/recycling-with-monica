using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey("escape")){
           Application.Quit();
       } 
    }
    public void OnClickStartGame(){
        SceneManager.LoadScene("GameScene");
    }
    public void OnClickCredits(){
         SceneManager.LoadScene("CreditsScene");
    }
    public void OnClickExitGame(){
        Application.Quit();
    }
}
