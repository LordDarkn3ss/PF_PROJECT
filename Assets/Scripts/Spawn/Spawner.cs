using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefab; //Prefab do inimigo spawnado
    [SerializeField]
    float timer,aumento; //Timer (tempo para o spawn) - Aumento (Aumento de dificuldade, diminuir tempo de spawn)
    void Start()
    {
        StartCoroutine(SpawnEnemy()); //Coroutine para rodar um "TIMER" em outro processo, evitando travar todo
                                      //o processo do jogo para esperar a��o...
    }
    void Update()
    {

    }

    IEnumerator SpawnEnemy() //Timer para spawnar o inimigo
    {
        while (true) //Sistema de repeti��o para ficar spawnando inimigos infinitamente 
        {
            yield return new WaitForSeconds(timer); //Retorna um tempo de espera at� a proxima linha
            Instantiate(prefab, transform.position, Quaternion.identity); //Instanciar os inimigos em cena
           if(timer >= 0.5f) //Se o tempo for maior que meio segundo
            {
                timer -= aumento; //diminuir o tempo de spawn
            }
            
        }
    }
    
}
