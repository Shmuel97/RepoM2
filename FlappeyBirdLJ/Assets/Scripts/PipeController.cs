using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PipeController : MonoBehaviour
{
    public float speed;
    public float rp;
    public float ipx;
    public float py;
    // Start is called before the first frame update
    void Start()
    {
        ipx=transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -ipx) {
            transform.position = Vector3.right * rp ;
            transform.position = new Vector3(ipx, Random.Range(-py,py),0.0f);
        }
    }
}
