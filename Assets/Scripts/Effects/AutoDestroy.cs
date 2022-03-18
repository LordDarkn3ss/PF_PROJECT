using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    [SerializeField]
    float tempo;
    void Start()
    {
        Destroy(gameObject, tempo);
    }
}
