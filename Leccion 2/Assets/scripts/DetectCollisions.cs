using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Se creo esta funcion para destruir los objetos que colisionan entre si
    //Con la opcion trigger del collider se puede usar esta función
    void OnTriggerEnter(Collider other){
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
