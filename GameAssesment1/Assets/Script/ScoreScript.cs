using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{

    //public variable
    public Text scoreDisplay;

    //private variables
    private int scoreValue = 0;

    //function to add the players score
    //not called by unity
    public void AddScore(int toAdd)
    {
        //update the numerical value to the score
        scoreValue = scoreValue + toAdd;
        if (scoreValue >=20)
        {
            SceneManager.LoadScene("Winning Screen");
        }
        

        //update the display of the score based on numerical value
        scoreDisplay.text = scoreValue.ToString();
    }

   
}
