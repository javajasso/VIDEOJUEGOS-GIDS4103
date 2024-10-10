using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject hueso;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");

        if (transform.position.x > 23) 
        {
            transform.position = new Vector3(
                23, //x
                transform.position.y,
                transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(
           hueso,
           transform.position,
           hueso.transform.rotation);
        }      

        transform.Translate(Vector3.right*Time.deltaTime*10*hor);
    }
}
