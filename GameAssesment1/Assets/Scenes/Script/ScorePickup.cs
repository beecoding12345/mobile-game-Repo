using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScorePickup : MonoBehaviour
{

    //public variable
    public int pickupvalue = 1;

    



    //this is our condition if the ball hits the bouncing slider
    void OnTriggerEnter2D(collider2D other)
    {
        score scoreScript = other.GetComponent<Score>();

        if (scoreScript != null)
        {
            scoreScript.AddScore(pickupvalue);



        }

    }

}
