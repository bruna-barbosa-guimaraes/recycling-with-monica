using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsScript : MonoBehaviour
{
    public Text pontosUI;
    public Text recordeUI;
    public int pontos = 0;
    
    void Update()
    {
      if(pontos > PlayerPrefs.GetInt("Recorde")){
          PlayerPrefs.SetInt("Recorde",pontos);
      }  
      pontosUI.text = "Pontos:" + pontos;
      recordeUI.text = "Recorde:" + PlayerPrefs.GetInt("Recorde");
    }
}
