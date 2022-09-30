using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverJoseComelon : MonoBehaviour
{
    //Este script se creo para poder mover a JoseComelon
    //Se creo la variable para la velocidad 
    public float vel = 5.0F;
    //Se creo la variable para limitar a JoseComelon y no salga del escenario 
    public float maximo = 24.6F;
    //Se crea el objeto para poder lanzar objetos con JoseComelon
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Si se teclea la tecla space se creara un objeto y lo lanzara
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        //Si la posicion de Jose es mayor al limite de la variable maximo, se le asiganra una posicion valida
        if(transform.position.x > maximo){
            transform.position = new Vector3(maximo, transform.position.y, transform.position.z);
        }
        //Si la posicion de Jose es menor al limite de la variable maximo en su valor negativo, se le asiganra una posicion valida
   
        if(transform.position.x < -maximo){
            transform.position = new Vector3(-maximo, transform.position.y, transform.position.z);
        }
        //Se se precionan las teclas Horizontales se cambiara el valor de flechas lo que modificara la posición de JoseComelon
        float flechas = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*vel*flechas);
    }
}
