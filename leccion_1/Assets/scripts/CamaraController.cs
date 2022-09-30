using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    /* Este script nos ayudara a que la camara siga al jugador */
    //Se crea el objeto el cual se asignara a jugador, en este caso a un carro
    public GameObject carro;
    // Se asigna una posicion inicial de la camara
    private Vector3 pos = new Vector3(0, 10, -10);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* A la posicion de la camara se le suma la posicion
         del carro la cual se movera o reducira dependiendo del carro */
        transform.position = carro.transform.position + pos;
    }
}
