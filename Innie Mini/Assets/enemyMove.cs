using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public int enemySpeed;
    public int yMoveDirection = 0; //0 is stay 1, up -1 down
    int top = 3;
    int bottom = -2;
    float speed = 5;

    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast (transform.position, new Vector2 (yMoveDirection, 0));
        gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (yMoveDirection, 0) * enemySpeed;

        if (hit.distance < -0.5f) {
            Flip();
        }

        if (transform.position.y >= top)
            yMoveDirection = -8;

        if (transform.position.y <= bottom)
            yMoveDirection = 1;

        transform.Translate(0, speed * yMoveDirection * Time.deltaTime, 0);
    }
    void Flip() {

        if (yMoveDirection > 0)
        {
            yMoveDirection = -1;

        }

        else {
            yMoveDirection = 5;
        }

    }
    
}
