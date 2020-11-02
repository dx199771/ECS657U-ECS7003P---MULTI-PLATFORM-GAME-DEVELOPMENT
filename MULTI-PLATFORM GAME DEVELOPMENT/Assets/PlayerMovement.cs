using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 1;
     

    // Update is called once per frame
    void Update()
    {
        float horAxis = Input.GetAxis("Horizontal");
        float verAxis = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horAxis,verAxis);

        GetComponent<Rigidbody2D>().velocity = new Vector2(horAxis*speed,verAxis*speed); //player's velocity of moving
        Vector2 direction = new Vector2(horAxis, verAxis);
        FindObjectOfType<PlayerAnimation>().SetDirection(direction); //assign animation to the character according to the direction
    }

}
