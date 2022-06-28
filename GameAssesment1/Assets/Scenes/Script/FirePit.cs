using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirePit : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collider)
    {
        SceneManager.LoadScene("GameLosing");
    }
}
