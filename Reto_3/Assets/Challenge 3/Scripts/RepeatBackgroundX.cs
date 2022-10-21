using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{

    //Variable tipo Vector 3
    private Vector3 startPos;

    //Variable auxiliar para repetir el fondo
    private float repeatWidth;

    private void Start()
    {
        //Tomamos el valor inicial del fondo
        startPos = transform.position; // Establish the default starting position 
        //Obtenemos el tamaño en x del fondo y lo dividimos entre 2
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; // Set repeat width to half of the background
    }

    private void Update()
    {
        // If background moves left by its repeat width, move it back to start position
        if (transform.position.x < startPos.x - repeatWidth)
        {
            //Cambiamos la posicion del fondo a la inicial 
            transform.position = startPos;
        }
    }

 
}


