using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsScript : MonoBehaviour
{
    public Text pontosUI; //pontos na tela
    public Text recordeUI; //pontos do recorde na tela
    public int pontos = 0; //valor inicial dos pontos

    //pontuacao e recordes
    void Update()
    {
        //se pontos for maior que pontuacao redorde anterior
        if (pontos > PlayerPrefs.GetInt("Recorde"))
        {
            //atualiza valor do recorde
            PlayerPrefs.SetInt("Recorde", pontos);
        }
        //pontuacao na tela atualizada
        pontosUI.text = "Pontos:" + pontos;
        //se a pontuacao for maior que a atual é gerado o recorde novo na tela
        recordeUI.text = "Recorde:" + PlayerPrefs.GetInt("Recorde");
    }
}
