using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomBoundary : MonoBehaviour
{
    Transform fratCatTransform;
    Rigidbody2D fratCatRB;
    Vector3 fratCatPosition;
    // Start is called before the first frame update
    void Start()
    {
        fratCatTransform = gameObject.GetComponent<Transform>();
        fratCatPosition = fratCatTransform.position;
        fratCatRB = gameObject.GetComponent<Rigidbody2D>();

    }

    void OnCollisionEnter2D(Collision2D col)
    { 
        if (col.gameObject.name == "boundary")
        {
            Debug.Log("hit bottom boundary");
            fratCatTransform.position = fratCatPosition;
            fratCatRB.velocity = new Vector2(0, 0);
        }




    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
