using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public float speed;
    public int direction = 1;
    public float threshold = 27;
    private Rigidbody rb;
    private float x;
    private float z;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Car";
        rb = GetComponent<Rigidbody>();
        x = rb.position.x;
        z = rb.position.z;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.position += Time.fixedDeltaTime * new Vector3(0,0,30 * direction);   
        if ( direction == 1 ) {
            if ( rb.position.z > threshold ) {
            rb.position = new Vector3(x, 0, z);
            }
        }
        if ( direction == -1 ) {
            if ( rb.position.z < threshold ) {
            rb.position = new Vector3(x, 0, z);
            }
        }
        
    }
}
