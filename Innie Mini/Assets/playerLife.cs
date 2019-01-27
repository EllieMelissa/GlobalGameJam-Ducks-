using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerLife : MonoBehaviour
{
    public int health;
    public bool hasDied;


    void Start()
    {
        hasDied = false;
       
    }

    void Update()
    {
        if (gameObject.transform.position.y < -6)
        {

            hasDied = true;
        }
        if (hasDied == true)
        {
            StartCoroutine("Die");

        }

    }

    IEnumerator Die() {

        SceneManager.LoadScene("Mini_Joe");
        yield return null;
    }


   }
