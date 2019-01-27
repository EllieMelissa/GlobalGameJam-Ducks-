using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    string[] sceneNames = { "Opening title scene", "Living Room", "Attic", "Mini_Joe" };
    static int counter = 0;


    public void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

            if (other.tag == "Player")
            {
            counter++; if (counter > sceneNames.Length - 1) counter = 0;
            SceneManager.LoadScene(sceneNames[counter]);
                
                Debug.Log("True");

            }


    }
}

