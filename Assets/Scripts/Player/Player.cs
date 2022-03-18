using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{

    [SerializeField]
    float jumpForce, checkGround, timeToFire, fireRate;
    [SerializeField]
    Transform groundDetect, pivot; //Detector do chão - Ponto de instancia para o projetil
    [SerializeField]
    LayerMask piso; //layer para a permissão do pulo
    [SerializeField]
    GameObject prefab; //projetil

    void Start()
    {
        
    }
    void Update()
    {
        Move();
        Shoot();
    }
    void Move()
    {

        Debug.DrawRay(groundDetect.position, new Vector2(0, -checkGround), Color.red); //Feedback visual
        if (Physics2D.Raycast(groundDetect.position, -groundDetect.up, checkGround, piso.value))
        {         // Posição do Detector de chão - apontando pra baixo, a partir do detector, retornar layer

            if (Input.GetKeyDown(KeyCode.Space)) //ao APERTAR o espaço
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce * 100));
                //adicionar força para cima - Pulo -
            }
        }
    }
    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time >= timeToFire)
        {
            timeToFire = Time.time + 1 / fireRate; //Evitar spamar projetil
        
            Instantiate(prefab, pivot.transform.position, Quaternion.identity);
            //instanciar Bala, a partir do PIVOT, mantendo o ângulo
        }
    }

    
}
