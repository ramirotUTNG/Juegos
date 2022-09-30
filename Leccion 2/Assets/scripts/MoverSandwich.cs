using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverSandwich : MonoBehaviour
{
    //Este script es para la velocidad de la comida y avance hacia delante
    //Se crea la variable para la velocidad del objeto
    public float speed = 40.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Se le da una velocidad en todo momento al objeto
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
    }
}
