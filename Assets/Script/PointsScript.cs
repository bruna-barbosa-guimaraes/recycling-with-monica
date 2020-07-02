using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsScript : MonoBehaviour
{
    public Text pontosUI;
    public Text recordeUI;
    public int pontos = 0;
    void Update()//pontuacao e recordes
    {
      if(pontos > PlayerPrefs.GetInt("Recorde"))
      {
          PlayerPrefs.SetInt("Recorde",pontos);
      }  
      pontosUI.text = "Pontos:" + pontos;
      recordeUI.text = "Recorde:" + PlayerPrefs.GetInt("Recorde");//se a pontuacao for maior que a atual é gerado o recorde novo
    }
}
