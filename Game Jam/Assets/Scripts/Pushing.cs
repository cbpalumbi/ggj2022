using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pushing : MonoBehaviour
{
    Rigidbody2D pushableObjectRigidbody;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "PushableBlock"){
            pushableObjectRigidbody = col.gameObject.GetComponent<Rigidbody2D>();
            Debug.Log("OnCollisionEnter2D");
             if (Input.GetKey(KeyCode.D)) {
                pushableObjectRigidbody.AddForce(transform.right * 80f);
             }
        }
        
    }
}

