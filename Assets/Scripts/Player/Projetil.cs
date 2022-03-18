using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil: MonoBehaviour
{
    

    [SerializeField]
    float speed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        //Sistema de movimento -> (direita) por trasform
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject,0); //Evitar LAG ao se destruir quando não mais necessario (fora de visão)
    }


}
