using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    // Start is called before the first frame update
    float flap;
    Rigidbody rb;
    
    void Start()
    {

        //Debug.Log("Hola, soy el start de este GO: " + gameObject.name);
        rb = GetComponent<Rigidbody>();
        flap = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            //Debug.Log("Espacio presionado " + gameObject.name);
            rb.velocity = new Vector3(0, 0, 0);
            rb.AddForce(0,flap,0,ForceMode.Impulse);
        }
        
    }
}
