using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public float speed = 2;

    private Rigidbody2D physicsBody = null;


    // Start is called before the first frame update
    void Start()
    {
        physicsBody = GetComponent<Rigidbody2D>();

        //physicsBody.velocity = new Vector2(2, 0);
    }

    // Update is called once per frame
    void Update()
    {

        float axisVal = Input.GetAxis("Horizontal");
        float yaxisVal = Input.GetAxis("Vertical");
        //physicsBody.velocity = new Vector2(axisVal * speed, yaxisVal * speed);


    }

    // programmer defined function (not part of unity)
    // to be called by the button
    //public = asscesible outside of this script
     public void MoveRight()
    {
        physicsBody.velocity = new Vector2(speed, 0);
    }

    public void MoveLeft()
    {
        physicsBody.velocity = new Vector2(speed, 0);
    }

    public void MoveUp()
    {
        physicsBody.velocity = new Vector2(speed, 0);
    }

    public void MoveDown()
    {
        physicsBody.velocity = new Vector2(speed, 0);
    }
}
