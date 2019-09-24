using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Cuando hago click en la pantalla ejecuta una animacion de la camara de forma
/// aleatoria
/// </summary>

public class ControlDisparo : MonoBehaviour
{
    public Animator animCamera;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("raton click");
        }
    }

}
