using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestruccion : MonoBehaviour
{
    public float tiempoVida = 5f;
    void Start()
    {
        Destroy(gameObject, tiempoVida);
    }

}
