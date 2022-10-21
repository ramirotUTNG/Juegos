using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    //Variable para posición
    private Vector3 startPos;
    
    //Variable auxiliar para repetir el fondo
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        //Se trae el valor real de la posición inicial
        startPos = transform.position;

        //Obtenemos el valor del box collider y lo dividimos entre 2
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //Condición que sucede si la posición actual es menor que la posición inicial menos 50
        if(transform.position.x < startPos.x -repeatWidth){
            //Asignación de la nueva posición que seria nuevamente la inicial
            transform.position = startPos;
        }
    }
}
