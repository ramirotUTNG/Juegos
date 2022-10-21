using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    //Se crea un arreglo de objetos 
    public GameObject[] objectPrefabs;
    //Variable para la espera de invocación
    private float spawnDelay = 2;
    //Intervalo entre cada invocación
    private float spawnInterval = 1.5f;

    //Se crea una variable de tipo PlayerControllerX
    private PlayerControllerX playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        //Invocamos repetidamente a la funcion SpawnObjects
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
        //Obtenemos el componente  de PlayerControllerX para Player
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    // Spawn obstacles
    void SpawnObjects ()
    {
        // Set random spawn location and random object index
        Vector3 spawnLocation = new Vector3(30, Random.Range(5, 15), 0);

        //Asiganmos valor aleatorio de 0 a el valor .length de objectPrefabs
        int index = Random.Range(0, objectPrefabs.Length);

        // If game is still active, spawn new object
        if (!playerControllerScript.gameOver)
        {
            //Creamos los objetos
            Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation);
        }

    }
}
