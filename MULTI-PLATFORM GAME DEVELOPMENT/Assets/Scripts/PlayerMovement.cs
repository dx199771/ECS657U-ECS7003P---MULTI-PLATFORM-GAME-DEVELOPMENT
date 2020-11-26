using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 1;
    void Start()
    {
        //initla position set up
        float xPos = -1.4f;
        float yPos = 10.86f;
        GetComponent<Rigidbody2D>().transform.localPosition = new Vector2(xPos, yPos);
    }

    // Update is called once per frame
    void Update()
    {
        float horAxis = Input.GetAxis("Horizontal"); //take X-axis and Y-axis from input
        float verAxis = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horAxis,verAxis);

        GetComponent<Rigidbody2D>().velocity = new Vector2(horAxis*speed,verAxis*speed); //player's velocity of moving
        Vector2 direction = new Vector2(horAxis, verAxis);
        FindObjectOfType<PlayerAnimation>().SetDirection(direction); //assign animation to the character according to the direction
    }

}
