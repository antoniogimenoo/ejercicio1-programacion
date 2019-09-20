using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patoclick : MonoBehaviour
{
    //Creamos una ariable de tipo Animator para poder modificar la velocidad de la animacion
    public Animator controlador;
    [SerializeField]
    int vida = 3;

    //Usamos SerializeField para mostrar una variable privada en Unity
    [SerializeField]
    //La variable velocidad cambiara la velocidad de animacion
    float velocidad = 1;

    // Start is called before the first frame update
    void Start()
    {
       // controlador = GetComponent<Animator>();
        controlador.speed = velocidad;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Pinchado");

        vida--;

        if (vida == 0)
        {
            Destroy(gameObject);
        }
    }
}
