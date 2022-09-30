using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    // Se crea el objeto array de las pelotas
    public GameObject[] ballPrefabs;

//Variables para los limites de la pelota
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    //Limite de creacione en y
    private float spawnPosY = 30;
//Espera para que se invoque cada pelota
    private float startDelay = 1.0f;
   
    void Start()
    {
        //Se llama la función SpawnRandomBall
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        //Valor aleatorio entre  y la cantidad de pelotas recividas en el array
   int ballindex = Random.Range(0, ballPrefabs.Length);
        //Generar pelota aleatoria en posición aleatoria
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
//Espera aleatoria de 1 a 5 para invocar pelota
    startDelay = Random.Range(1, 5);
        // Crear objeto de pelota en posicion aleatoria
        Instantiate(ballPrefabs[ballindex], spawnPos, ballPrefabs[ballindex].transform.rotation);
        //Se llama a si misma la función
        Invoke("SpawnRandomBall", startDelay);
    }

}
