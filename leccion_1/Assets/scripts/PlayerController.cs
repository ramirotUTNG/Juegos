using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  //Se crea la variable para la velocidad
    public float velocidad;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //asignamos a una variable el valor de la flecha del teclado
      float avanza = Input.GetAxis("Vertical");
      float girar = Input.GetAxis("Horizontal");
     
  /* Para la velocidad del carro se uso una variable velocidad que podra darsele valor desde unity
  ademas de que se toma el valor de teclear la flecha adelante. Si no se preciona se tomara como 0 y no avanzara*/
     transform.Translate(Vector3.forward * Time.deltaTime*20*velocidad*avanza);
     //con las flechas horizontales se daran valores negativos o positivos, 
     //los cuales haran al carro girar a la izquierda o derecha
     transform.Rotate(Vector3.up, Time.deltaTime*30*girar);
    }
}
