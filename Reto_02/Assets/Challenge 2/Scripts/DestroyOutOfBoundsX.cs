using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    //Con este script elinaremos los objetos que salgan de cierto rango
    //Se crean las variables con los limites
    private float leftLimit = -40;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Eliminar al perro si la posicion x es menor al limite dado a la variable leftLimit
       
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Eliminar la pelota si el valor es menor al dado en la variable bottomLimit

        else if (transform.position.y < bottomLimit)
        {
            //Se destruye el objeto
            Destroy(gameObject);
        }

    }
}
