using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLosing : MonoBehaviour
{
    public void RestartButton(){
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
