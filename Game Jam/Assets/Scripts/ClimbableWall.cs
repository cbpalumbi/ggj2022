using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbableWall : MonoBehaviour
{
    int speed = 7;
    Transform transform;
    public bool isClimbing;
    
    // Start is called before the first frame update
    void Start()
    {
        transform = gameObject.GetComponent<Transform>();
        isClimbing = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionStay2D(Collision2D col){
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            if(col.gameObject.tag == "ClimbableWall"){
                transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
                isClimbing = true;
            } else {
                isClimbing = false;
            }
        }
    }
}
