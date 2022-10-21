using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //Variable auxiliar para cuando se acaba el juego
    public bool gameOver;

    //Variable para asignar la fuerza de de empuje en eje y
    public float floatForce;
    //Variable para modificar la gravedad
    private float gravityModifier = 1.5f;
    //Variable tipo Rigidbody para almacenar caracteristicas de la misma
    private Rigidbody playerRb;

    //Variable tipo ParticleSystem para almacenar caracteristicas de la misma
    public ParticleSystem explosionParticle;

    //Variable tipo ParticleSystem para almacenar caracteristicas de la misma
    public ParticleSystem fireworksParticle;

    //Variable tipo AudioSource para almacenar caracteristicas de la misma
    private AudioSource playerAudio;

    //Variable tipo AudioClip para almacenar caracteristicas de la misma
    public AudioClip moneySound;

    //Variable tipo AudioClip para almacenar caracteristicas de la misma
    public AudioClip Boing;

    //Variable tipo AudioClip para almacenar caracteristicas de la misma
    public AudioClip explodeSound;

    //Variable auxiliar para quitar el control al jugador
    public bool tooHigh;

    // Start is called before the first frame update
    void Start()
    {
        //Asignación de la gravedad modificada
        Physics.gravity *= gravityModifier;
        //Obtenemos el componente AudioSoruce
        playerAudio = GetComponent<AudioSource>();
        //Obtenemos el componente Rigidbody
        playerRb = GetComponent<Rigidbody>();
        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        //Condicion si la posicion en y es mayor a 15 se asigna falso a tooHigh sino se asigna verdadero
        if(transform.position.y > 15) {
            tooHigh = false;
        }else{
            tooHigh = true;
        }

        // While space is pressed and player is low enough, float up
        //Si se preciona la tecla espacio, no es game over y too high es verdadero entonces el globo se elevara
        if (Input.GetKey(KeyCode.Space) && !gameOver && tooHigh)
        {
            //Con esto se eleva el globo usando la variable floatForce
            playerRb.AddForce(Vector3.up * floatForce);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            //Se ejecutan las particulas de exposion 
            explosionParticle.Play();
            //Se ejecuta el sonido de explosion al maximo volumen
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            //Se cambia la variable gameOver a verdadero
            gameOver = true;
            //Se manda mensaje a consola
            Debug.Log("Game Over!");
            //Se destruye el otro objeto
            Destroy(other.gameObject);
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            //Se ejecutan las particulas de fuegos artificiales
            fireworksParticle.Play();
            //se ejecuta el sonido de dinero al maximo volumen
            playerAudio.PlayOneShot(moneySound, 1.0f);
            //Se destruye el otro objeto
            Destroy(other.gameObject);
        //Se compara si esta tocando el juego y no es game over
        } else if (other.gameObject.CompareTag("Ground") && !gameOver)
        {
            //Se agrega fuerza en el eje y al globo
            playerRb.AddForce(Vector3.up*10, ForceMode.Impulse);
            //Se reproduce un sonido al maximo volumen
            playerAudio.PlayOneShot(Boing, 1.0f);
        }

    }

}
