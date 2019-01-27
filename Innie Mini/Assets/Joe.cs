using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joe : MonoBehaviour
{

    public int playerSpeed = 10;
    private bool facingRight =  false;
    public int playerJumpPower = 1250;
    private float moveX;
    public bool touchGround;


    //For each frame update is called
    void Update()
    {
        //Controls
        moveX = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        //Player Direction
        if (moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        //Physics

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump() {
        GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJumpPower);
        touchGround = false;
    }

    void FlipPlayer() {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    void onCollisionEnter2D (Collision2D col) {

     if (col.gameObject.tag == "ground") {
            touchGround = true;
        }
       
    }

    //function OnControllerColliderHit(hit, ControllerColliderHit)
    //{
    //    if (hit.transform.tag == "Player")
    //    {
    //        Debug.Log("Hit the Enemy");
    //        Destroy(gameObject);
    //    }

    //}

}



