using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    //Este script es para que la camara siga al jugador
    public GameObject plane;
    //Se le asigna el lugar de la camara 
    private Vector3 offset = new Vector3(28, 2, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //al valor de la camara se le suma la posicion del jugador y se asigna la nueva posicion 
        transform.position = plane.transform.position + offset;
    }
}
