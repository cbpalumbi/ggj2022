using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbableWall : MonoBehaviour
{
    int speed = 5;
    Transform transform;
    
    // Start is called before the first frame update
    void Start()
    {
        transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay2D(Collision2D col){
        if(Input.GetKey(KeyCode.D)){
            if(col.gameObject.tag == "ClimbableWall"){
                Debug.Log(col.gameObject.name + " : " + gameObject.name + " : ");
                //transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
                //transform.Translate(0, Time.deltaTime, 0, Space.World);
                transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);

        }
        }
        
    }

    
}
