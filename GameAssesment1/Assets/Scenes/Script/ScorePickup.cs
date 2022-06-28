using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScorePickup : MonoBehaviour
{

    //public variable
    public int pickupvalue = 1;





    //this is our condition if the ball hits the bouncing slider
    void OnCollisionEnter2D(Collision2D collider)

    {


        ScoreScript scoreScript = collider.collider.GetComponent<ScoreScript>();

        if (scoreScript != null)
        {
            scoreScript.AddScore(pickupvalue);

        }

    }

}
