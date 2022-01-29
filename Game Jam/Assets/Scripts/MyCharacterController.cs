using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    public LayerMask groundLayer;



    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            myRigidbody.AddForce(-transform.right * 10f);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            myRigidbody.AddForce(transform.right * 10f);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            myRigidbody.AddForce(-transform.up * 10f);
        }
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && IsGrounded()) {
            myRigidbody.AddForce(transform.up * 400f);
        }

        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) &&  (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))) {
            myRigidbody.AddForce(-transform.right * 20f);
        }
        if ((Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow)) &&  (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))) {
            myRigidbody.AddForce(transform.right * 20f);
        }


        if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) &&  (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))) {
            myRigidbody.AddForce(-transform.up * 20f);
        }
        
        
    
    }

    public bool IsGrounded() {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 2f;
        Debug.DrawRay(position, direction, Color.green);
        RaycastHit2D hitLeft = Physics2D.Raycast(position - new Vector2(1.3f, 0), direction, distance, groundLayer);
        RaycastHit2D hitRight = Physics2D.Raycast(position + new Vector2(1.3f, 0), direction, distance, groundLayer);
        if (hitLeft.collider != null || hitRight.collider != null) {
            return true;
        }
        return false;
    }

}
