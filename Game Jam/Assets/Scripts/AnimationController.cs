using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    SpriteRenderer myRenderer;
    Animator myAnimator;
    Rigidbody2D rb;
    MyCharacterController myCharacterController;
    ClimbableWall myClimbableWall;
    bool isWalking;
    bool isJumping;
    bool isClimbing;
    
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
        myAnimator = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        myCharacterController = gameObject.GetComponent<MyCharacterController>();
        myClimbableWall = gameObject.GetComponent<ClimbableWall>();
        myAnimator.SetBool("is_walking", false);
    }

    public void turnToFaceLeft() {
        myRenderer.flipX = true;
    }

    public void turnToFaceRight() {
        myRenderer.flipX = false;
    }

    bool GetUpdatedGroundedState() {
        return myCharacterController.IsGrounded();
    }
    bool GetUpdatedClimbingState() {
        return myClimbableWall.isClimbing;
    }

    void Update() {
        Debug.Log("is climbing is " + isClimbing);
        // if (GetUpdatedClimbingState()) {
        //     isClimbing = true;
        // } else {
        //     isClimbing = false;
        // }
        if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow))) {
            if (!myRenderer.flipX) {
                turnToFaceLeft();
            }
            if (GetUpdatedClimbingState()) { 
                isJumping = false;
                isClimbing = true;
            } else {
                isClimbing = false;
            }
        }
        if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow))) {
            if (myRenderer.flipX) {
                turnToFaceRight();
            }
            if (GetUpdatedClimbingState()) { 
                isJumping = false;
                isClimbing = true;
            } else {
                isClimbing = false;
            }
        }
        if (GetUpdatedGroundedState()){
            isJumping = false;
            if (rb.velocity.x < 0.1f) {
                isWalking = false;
                isClimbing = false;
            } else {
                isWalking = true;
            }
        } else {
            if (!isClimbing) {
                isJumping = true;
            }
        }
        myAnimator.SetBool("is_climbing", isClimbing);
        myAnimator.SetBool("is_walking", isWalking);
        myAnimator.SetBool("is_jumping", isJumping);
    }
}
