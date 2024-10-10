using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpinPropeller : MonoBehaviour
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
        //transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * 1);

        transform.Rotate(Vector3.forward * speed * Time.deltaTime * 1);

        // tilt the plane up/down based on up/down arrow keysS
        //transform.Rotate(Vector3.left * verticalInput * Time.deltaTime);



    }
}
