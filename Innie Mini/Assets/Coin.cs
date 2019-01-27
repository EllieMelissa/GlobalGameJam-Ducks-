using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Coin : MonoBehaviour
{
    float originalY;
    public GameObject Player;
    public float floatStrength = 1; 
    void Start()
    {
        this.originalY = this.transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x,
            originalY + ((float)Math.Sin(Time.time) * floatStrength),
            transform.position.z);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("We got a collision");
        if (other.gameObject.tag == "Boundary")
        {
            return;
        }
        Debug.Log("Collision with object not tagged as Boundary");
        Destroy(gameObject);
        if (other.gameObject.tag == "Lazer")
        {
            Debug.Log("Collision with object tagged as Lazer");
            Destroy(gameObject);
        }
    }



}



