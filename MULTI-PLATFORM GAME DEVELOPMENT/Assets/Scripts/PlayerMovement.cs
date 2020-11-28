using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject instructionPanel;
    public float speed = 1;
    private bool isMoving = false;
    //movement direction
    private float horAxis;
    private float verAxis;
    public float initialXPos;
    public float initialyPos;

    void Awake()
    {
        SoundManager.Initialize();
    }

    void Start()
    {
        //initla position set up
        float xPos = initialXPos;
        float yPos = initialyPos;

        GetComponent<Rigidbody2D>().transform.localPosition = new Vector2(xPos, yPos);
    }

    // Update is called once per frame
    void Update()
    {
        if (instructionPanel.activeSelf) //cannot move when instruction panel open
        {
            horAxis = 0;
            verAxis = 0;
            
        }
        else //if instruction panel close(game start)
        {
            horAxis = Input.GetAxis("Horizontal"); //take X-axis and Y-axis from input
            verAxis = Input.GetAxis("Vertical");
            Vector2 movement = new Vector2(horAxis, verAxis);

            GetComponent<Rigidbody2D>().velocity = new Vector2(horAxis * speed, verAxis * speed); //player's velocity of moving
            Vector2 direction = new Vector2(horAxis, verAxis);
            FindObjectOfType<PlayerAnimation>().SetDirection(direction); //assign animation to the character according to the direction

            if (GetComponent<Rigidbody2D>().velocity.x != 0 || GetComponent<Rigidbody2D>().velocity.y != 0)
            {
                isMoving = true;
            }
            else
            {
                isMoving = false;
            }

            if (isMoving)
            {
                //if (!SoundManager.Sound.HeroMove.isPlaying())
                //{
                SoundManager.PlaySound(SoundManager.Sound.HeroMove);
                //}
                //else
                //{
                    //SoundManager.Sound.HeroMove.Stop();
                //}
            }

        }
    }
}
