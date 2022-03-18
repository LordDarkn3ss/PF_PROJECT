using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GlobalScore : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI record; //Pontua��o Record na interface de menu

    void Start()
    {
        if (PlayerPrefs.GetInt("Record") <= 0) { PlayerPrefs.SetInt("Record", 0); } //colocando uma informa��o inicial
                                                                                    //evitar possivel bug
    }

    void Update()
    {
        record.text = "Record: " + PlayerPrefs.GetInt("Record"); //Atualizar interface de menu com record atual
    }
}
