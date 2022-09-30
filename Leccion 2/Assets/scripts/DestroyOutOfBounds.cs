using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
/* Este script sera usado para destruir los objetos que salgan de cierto rango del juego */
    //Variable para destruir los objetos que salgan del rango con valor en el eje z 
    private float topBound = 30;
    private float lowerBound = -13;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* Se crea una condición. Si el valor del objeto es mayor al valor de la variable 
        topBound se destruira. Si el objeto es menor al valor de la variable lowerBound se destruira el objeto*/
       if(transform.position.z > topBound){
        Destroy(gameObject);
       } else if(transform.position.z < lowerBound)
       {
        Destroy(gameObject);
       }
    }
}
