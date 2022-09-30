using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  //Este script es para que se generen animales al azar 
  //Se crea un array de objetos, los cuales usaremos para los animales a invocar
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
  
    void Start()
    {
      //Al iniciar llamaremos a la funcion SpawnRandomAnimal, el cual recive como parametros 
      //el valor de espera de invocación y el intervalo entre cada invocación
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }


    void Update()
    {
 
    }
    void SpawnRandomAnimal(){
            //Se dara un valor aleatorio entre 0 y la cantidad de animales dados al objeto array
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            //Se toma una lugar aleatorio con la variable spawnRangeX y spawnPosZ para invocar animales en lugares al azar
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
            0, spawnPosZ);
            //Se crea el objeto al azar y posición al azar
            Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
