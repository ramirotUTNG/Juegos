using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helices : MonoBehaviour
{
    //Este script es para hacer girar las helices
    //El valor de la velocidad de giro de las helices
    public float velocidadGiro = 1000.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Se genera el giro al sumar la velocidad con un movimiento constante 
        transform.Rotate(Vector3.forward * velocidadGiro);
    }
}
