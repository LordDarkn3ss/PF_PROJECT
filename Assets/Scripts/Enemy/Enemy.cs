using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    ParticleSystem magicExplosion; //Feedback visual - efeito de particulas (magia)
    [SerializeField]
    ParticleSystem EnemyDie; //Feedback visual - efeito de particulas (Inimigo Morrendo)
    [SerializeField]
    float speed;
    void Start()
    {
        
    }
    void Update()
    {
        
        if(UIGame.score / 20<25) //se a pontuação/20 for menor que 25
        {
            transform.position = new Vector2(transform.position.x - (speed+UIGame.score/20) * Time.deltaTime, transform.position.y); //manter aumento de velocidade em relação a pontuação
            
        }
        else
        {
            transform.position = new Vector2(transform.position.x - (25+speed) * Time.deltaTime, transform.position.y);
            //velocidade limite 25 + velocidade base do inimigo
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
     if(collision.tag == "Bullet") //ao colidir com o projetil
        {
            UIGame.score++; //acrescentar +1 ponto
            Instantiate(magicExplosion, collision.gameObject.transform.position, Quaternion.identity);
            Destroy(collision.gameObject, 0);  //destroir a bala
            Instantiate(EnemyDie,new Vector2(transform.position.x,transform.position.y+0.5f), Quaternion.identity);
            Destroy(gameObject, 0); //se destruir
        }
    }

}
