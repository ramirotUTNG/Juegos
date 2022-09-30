using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float tiempoEspera = 1;
    private float tiempoDisparoEspera = 0; 
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > tiempoDisparoEspera)
        {   tiempoDisparoEspera = Time.time + tiempoEspera;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
