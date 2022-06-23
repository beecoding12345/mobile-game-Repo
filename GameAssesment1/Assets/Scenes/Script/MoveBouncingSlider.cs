using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBouncingSlider : MonoBehaviour
{

    public float speed = 2;

    private Rigidbody2D physicsBody = null;



    // Start is called before the first frame update
    void Start()
    {
        physicsBody = GetComponent<Rigidbody2D>();

       
    }

    // Update is called once per frame
    void Update()
    {   /*
        float axisValX = Input.GetAxis("Horizontal");

        physicsBody.velocity = new Vector2(axisValX * speed,0);
        */

    }


    public void MoveRight()
    {
        physicsBody.velocity = new Vector2(speed, 0);
    }

    public void MoveLeft()
    {
        physicsBody.velocity = new Vector2(-speed, 0);
    }
}

