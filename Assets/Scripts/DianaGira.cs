using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DianaGira : MonoBehaviour
{
    Animator animacionDeLaDiana;

    //Creamos una variable tipo Animator para poder cargar mas adelante las animaciones
    void Start()
    {
        //Guardamos el componente Animator en la variable de antes
        animacionDeLaDiana = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        //Al pulsar con el raton en la diana ejecutamos la animacion con el trigger
        //Cuidado la mayusculas y minusculas
        EjecutarAnimacion();
        //Con Invoke retrasamos la funcion EjecutarAnimacion 2 segundos
        Invoke("EjecutarAnimacion", Random.Range(1,6));
    }

    //Tenemos que crear una funcion para poder invocarla
    void EjecutarAnimacion()
    {
        //Volvemos a llamar al trigger al cambiar la animacion
        animacionDeLaDiana.SetTrigger("Activar");
    }
}
