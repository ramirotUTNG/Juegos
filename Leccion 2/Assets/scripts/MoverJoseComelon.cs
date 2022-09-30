using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverJoseComelon : MonoBehaviour
{
    public float vel = 5.0F;
    public float maximo = 24.6F;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        if(transform.position.x > maximo){
            transform.position = new Vector3(maximo, transform.position.y, transform.position.z);
        }
        if(transform.position.x < -maximo){
            transform.position = new Vector3(-maximo, transform.position.y, transform.position.z);
        }
        float flechas = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*vel*flechas);
    }
}
