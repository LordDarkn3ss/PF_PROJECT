using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;


public class UIGame : MonoBehaviour
{
    



    [SerializeField]
    TextMeshProUGUI scoreInGame; //Pontuação na Interface de jogo
    public static int score;
    void Start()
    {
        score = 0; // Começar sempre em zero
    }

    void Update()
    {

        scoreInGame.text = ""+score; //atualizar a interface com a pontuação atual

        if (score > PlayerPrefs.GetInt("Record")) //Atualizar record quando o mesmo for batido
        {
            PlayerPrefs.SetInt("Record", score); //salvar record na memoria 
        }
    }
}
