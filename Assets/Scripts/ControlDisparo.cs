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
    public GameObject agujero;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Temblor();
            AgujeroBala();
        }
    }
    /// <summary>
    /// Ejecuta el trigger aleatorio de la cámara
    /// </summary>

    void Temblor()
    {
        //Componemos el nombre aleatorio del trigger
        string nombreTrigger = "shot" + Random.Range(1, 4);
        //Ejecutamos el trigger
        animCamera.SetTrigger(nombreTrigger);
    }

    /// <summary>
    /// Crea un sprite en la posición del puntero del ratón
    /// </summary>
    void AgujeroBala()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mousePos);
        Vector3 agujeroPos = new Vector3(mousePos.x, mousePos.y, 0);
        Instantiate(agujero, agujeroPos,Quaternion.identity);
    }

}


