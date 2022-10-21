using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    //Variable para la velocidad
    public float speed;

    //Variable tipo PlayerControllerX 
    private PlayerControllerX playerControllerScript;

    //Variable para eliminar objetos en el limite
    private float leftBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        //Se traen las caracteristicas de PlayerControllerX asignadas a Player
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    // Update is called once per frame
    void Update()
    {
        // If game is not over, move to the left
        if (!playerControllerScript.gameOver)
        {
            //Se usa para que se mueva el objeto a la izquierda
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }

        // If object goes off screen that is NOT the background, destroy it
        if (transform.position.x < leftBound && !gameObject.CompareTag("Background"))
        {
            //Se destruye el objeto
            Destroy(gameObject);
        }

    }
}
