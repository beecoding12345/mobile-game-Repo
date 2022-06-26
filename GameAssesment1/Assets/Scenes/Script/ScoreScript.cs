using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public Text MyscoreText;
    private int scoreNum;

    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0
        MyscoreText.text = "score : " + scoreNum;
    }

   
}
