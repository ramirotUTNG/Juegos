using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //Este script es para mover al jugador
    //Se crea la variable de velocidad
    public float speed;
    //Se crea la variable para la velocidad de la rotacion
    public float rotationSpeed;
    //Se crea la variable para los valores de usar las flechas verticales
    public float verticalInput;
    //Se crea la variable para los valores de usar las flechas horizontales
    public float horizontalInput;
   
    void Start()
    {

    }

    
    void FixedUpdate()
    {
        // Se obtiene el valor de usar las teclas verticales
        verticalInput = Input.GetAxis("Vertical");
        //Se obtiene el valor de usar las teclas horizontales
        horizontalInput = Input.GetAxis("Horizontal");
        // Mover al jugador con un movimiento constante
        transform.Translate(Vector3.forward * Time.deltaTime*speed);

        // tilt the plane up/down based on up/down arrow keys
        //mover  arriba o abajo dependiento del uso de las teclas verticales
        transform.Rotate(Vector3.right  *2*verticalInput);
        //mover izquierda o derecha dependiendo del uso de las teclas horizontales
        transform.Rotate(Vector3.up  * rotationSpeed*30*horizontalInput);
        

    }
}
