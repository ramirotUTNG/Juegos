using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    //Variable para la velocidad
    private float speed = 30;

    //Crreamos una variable para llamar al script PlayerController
    private PlayerController playerControllerScript;

    //Variable para el limite de los objetos
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        //Traemos todos los componentes de playerController relacionado con Player
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Condición si gameOver es falso los objetos seguiran moviendose
        if(playerControllerScript.gameOver==false){
            //Movimiento a la izquierda de los objetos
            transform.Translate(Vector3.left* Time.deltaTime * speed);

        }
        //Condición que destruye los objetos si sobrepasan cierto limite
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle")){
            Destroy(gameObject);
        }
    }
}
