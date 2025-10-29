using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    // Start is called before the first frame update
    public float flap;
    public float gravity;
    public int score;
    Rigidbody rb;
    
    void Start()
    {

        //Debug.Log("Hola, soy el start de este GO: " + gameObject.name);
        rb = GetComponent<Rigidbody>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce (Vector3.down * gravity);
        if (Input.GetKeyDown(KeyCode.Space)) {
            //Debug.Log("Espacio presionado " + gameObject.name);
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * flap, ForceMode.VelocityChange);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("He chocado con: "+collision.gameObject.name);
        
        Time.timeScale = 0.0f;
    }

    private void OnTriggerExit(Collider other)
    {
        score++;
        Debug.Log("SCORE: "+score);
    }
}
