using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;


public class UIGame : MonoBehaviour
{
    



    [SerializeField]
    TextMeshProUGUI scoreInGame; //Pontua��o na Interface de jogo
    public static int score;
    void Start()
    {
        score = 0; // Come�ar sempre em zero
    }

    void Update()
    {

        scoreInGame.text = ""+score; //atualizar a interface com a pontua��o atual

        if (score > PlayerPrefs.GetInt("Record")) //Atualizar record quando o mesmo for batido
        {
            PlayerPrefs.SetInt("Record", score); //salvar record na memoria 
        }
    }
}
