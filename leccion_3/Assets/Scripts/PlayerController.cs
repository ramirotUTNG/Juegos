using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerController : MonoBehaviour
{
    //Variable para traer la ruta del audio
    private AudioSource playerAudio;

    //Variable de sonido para salto
    public AudioClip jumpSound;

    //Variable de sonido para cuando choca 
    public AudioClip crashSound;


    //Variable para usar la animación de salpicadura
    public ParticleSystem dirtParticle;

    //Variable para usar la animación de explosión
    public ParticleSystem explosionParticle;

    //Variable auxiliar para la animación del salto
    private Animator playerAnim;
    
    //Se crea una variable propiedades del rigidbody
    private Rigidbody playerRb;

    //Variable para la fuerza del salto
    public float jumpForce;

    //Variable para la gravedad del jugador
    public float gravityModifier;

    //Variable para saber si esta tocando el suelo
    public bool isOnGround = true;

    //Variable auxiliar para gameOver
    public bool gameOver = false;

    void Start()
    {
        //Se trae la propiedad Rigidbody del jugador
        playerRb = GetComponent<Rigidbody>();
        //Forzaremos al jugador a hacer un salto al inicio de la partida
        //playerRb.AddForce(Vector3.up*1000); 

        //Se modifica la gravedad   
        Physics.gravity *= gravityModifier;

        //Traemos los datos del componente Animator
        playerAnim = GetComponent<Animator>();

        //Traemos los datos del componente 
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Condición de salto si se preciona la barra espaciadora
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver){
            //Se le da fuerza para realizar el salto en este caso
            //se usa ForceMode para que se aplique la fuerza de inmediato
            // y sea un poco mas rapido el salto
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround= false;
            //Asiganmos la animación de salto
            playerAnim.SetTrigger("Jump_trig");
            // detener la animación de salpicadura 
            dirtParticle.Stop();

            //Reproducimos el sonido de salto con el volumen mas alto
            playerAudio.PlayOneShot(jumpSound, 0.9f);
        }
        
    }

    //Metodo que se ejecuta cuando el jugador colisiona con algo 
    private void OnCollisionEnter(Collision other)
    {
        //Pasa a ser verdadero para que pueda saltar nuevamente el jugador
        //isOnGround = true;

        //Condición que pasa si se colisiona con un objeto con la etiquera Ground
        if(other.gameObject.CompareTag("Ground")){
            //Pasa a ser verdadero para que pueda saltar nuevamente el jugador
            isOnGround = true;

             //Activar la animación de salpicadura 
            dirtParticle.Play();

        //Condición que pasa si se colisiona con un objeto con la etiquera Obstacle
        }else if(other.gameObject.CompareTag("Obstacle")){

            //Se cambia a verdadero si se colisiona con un objeto
            gameOver = true;
            //Se envia un mensaje a la consola 
            Debug.Log("Game Over!");

            //Se asigna la variable de muerte
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);

            //Ejecutamos la animación de exploción
            explosionParticle.Play();

             //detener la animación de salpicadura 
            dirtParticle.Stop();
            
            //Reproducimos el sonido de choque con el volumen mas alto
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
