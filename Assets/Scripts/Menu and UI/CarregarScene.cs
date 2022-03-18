using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarScene : MonoBehaviour
{
    




    [SerializeField]
    string NomeScene;

    public void Carregar() // Carregar Scene
    {
        SceneManager.LoadScene(NomeScene);
    }
    public void ResetRecord()                 // Resetar antes da Build
    {
        PlayerPrefs.SetInt("Record", 0);
    }

    public void QuitGame()                 // Sair do jogo
    {
        Application.Quit();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy") // Game Scene GAMEOVER
        {
            Carregar();
        }
    }
  
   

}
