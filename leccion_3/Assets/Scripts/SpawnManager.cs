using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //variable de referencia para la creación de objetos
    public GameObject ObstaclePrefab;

    //Variable para asignar la posición donde se creara el nuevo obstaculo
    private Vector3 spawnPos = new Vector3(25, 0, 0);

    //Variable de espera de creación de objetos
    private float startDelay = 2;
    //Variable que repite la creación de objetos
    private float repeatRate = 2;

    //Creamos una variable para llamar al script PlayerController
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        //Se instancia la creacion del objeto al iniciar el juego en la posición dada a la variable y con cierta rotación
        //Instantiate(ObstaclePrefab, spawnPos, ObstaclePrefab.transform.rotation);
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);

        //Traemos todos los componentes de playerController relacionado con Player
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Metodo para crear obstaculos
    void SpawnObstacle(){
        //Condición si gameOver es falso los objetos seguiran moviendose
        if(playerControllerScript.gameOver==false){
            //Se crea un objeto
            Instantiate(ObstaclePrefab, spawnPos, ObstaclePrefab.transform.rotation);
        }
    }
}
