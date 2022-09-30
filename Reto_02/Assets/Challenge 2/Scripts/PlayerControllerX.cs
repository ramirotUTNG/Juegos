using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //Este script se usa para controllar al jugador 
    //Se crea el objeto de un perro 
    public GameObject dogPrefab;
    //Se creala variable para la espera entre lanzamiento de cada perro
    public float tiempoEspera = 1;
    //Se crea una variable auxiliar en 0 para poder asignar el tiempo de espera
    private float tiempoDisparoEspera = 0; 
    
    void Update()
    {
        //Si se teclea space se lanza un perro y si no ha pasado el segundo no puede lanzar otro perro
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > tiempoDisparoEspera)
        {  
             tiempoDisparoEspera = Time.time + tiempoEspera;
             //Se crea el objeto del perro
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
