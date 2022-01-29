using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    SpriteRenderer myRenderer;
    Animator myAnimator;
    Rigidbody2D rb;
    bool isWalking;
    
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
        myAnimator = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        myAnimator.SetBool("is_walking", false);
    }

    public void turnToFaceLeft() {
        myRenderer.flipX = true;
    }

    public void turnToFaceRight() {
        myRenderer.flipX = false;
    }

    void Update() {
        if ((Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.LeftArrow))) {
            //isWalking = true;
            if (!myRenderer.flipX) {
                turnToFaceLeft();
            }
        }
        if ((Input.GetKeyDown(KeyCode.D)) || (Input.GetKeyDown(KeyCode.RightArrow))) {
            //isWalking = true;
            if (myRenderer.flipX) {
                turnToFaceRight();
            }
        }
        // if (rb.velocity != Vector2.zero) {
        //     myAnimator.SetBool("is_walking", true);
        // }
        if (rb.velocity != Vector2.zero) {
            isWalking = true;
        } else {
            isWalking = false;
        }
        myAnimator.SetBool("is_walking", isWalking);
    }
}
