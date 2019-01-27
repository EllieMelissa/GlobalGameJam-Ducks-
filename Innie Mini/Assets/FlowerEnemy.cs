using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower_Enemy : MonoBehaviour
{
    public int enemySpeed = 0;
    //public int xMoveDirection = 1;//0 is stay 1, up -1 down
    ////int top = 3;
    //int bottom = -3;
    //float speed = 5;

    //void Update()
    //{
    //    RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(xMoveDirection, 0));
    //    gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xMoveDirection, 0) * enemySpeed;
    //    if (hit.distance < 0.6f)
    //    {
    
    //    }

    //    if (transform.position.x >= top)
    //        xMoveDirection = -8;

    //    if (transform.position.x <= bottom)
    //        xMoveDirection = 1;

    //    transform.Translate(0, speed * xMoveDirection * Time.deltaTime, 0);
}
