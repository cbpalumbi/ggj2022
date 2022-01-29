using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            myRigidbody.AddForce(-transform.right * 20f);
        }
        if (Input.GetKey(KeyCode.D)) {
            myRigidbody.AddForce(transform.right * 20f);
        }
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W)) {
            myRigidbody.AddForce(transform.up * 20f);
        }
    }
}
