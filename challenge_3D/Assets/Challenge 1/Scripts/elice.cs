using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elice : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");


        // move the plane forward at a constant rate
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * 10);

        // tilt the plane up/down based on up/down arrow keysS
        //transform.Rotate(Vector3.left * verticalInput * Time.deltaTime);
       

        //transform.position = Vector3.up;
    }
}
