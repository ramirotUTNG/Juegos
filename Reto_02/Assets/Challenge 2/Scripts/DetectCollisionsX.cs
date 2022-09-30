using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
//Si se detecta una colicion entre dos objetos uno de ellos se destruira, en este caso la pelota
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
