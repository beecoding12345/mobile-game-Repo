using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {   //insert action here
        Debug.Log("Collision Happend!");

        //IF  a collision starts with a certain object....
        if (collision.gameObject.name == "Wall")
        {
            //insert action here
            Debug.Log("Collided with Wall");
        }

        //if a collision starts with an object contaning a certain tag....
        if (collision.gameObject.tag == "Blocker")
        {
            Debug.Log("Collided with Blocker tagged Object");
        }

        //if a collision starts with an object on a certain physics layer....
        if (collision.gameObject.layer == LayerMask.NameToLayer("Level")) ;
        {
            //insert ation here
            Debug.Log("Collided with Level layer Object");
        }

        //if collision starts with a certain component attached....
        SpriteRenderer otherComponent = collision.gameObject.GetComponent<SpriteRenderer>();
        //if(otherComponent)//checking if getComponent succesfully found a component
        {
            //insert action here
            Debug.Log("Collided with Object with sprite renderer");

            //action change color of sprite
            otherComponent.color = Color.green;
        }
    }



}
