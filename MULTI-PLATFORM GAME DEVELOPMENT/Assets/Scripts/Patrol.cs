using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Patrol : MonoBehaviour
{
    public float speed;
    public Text infoText;

    public Transform[] moveSpots;
    private int randomSpot;
    public float startWaitTime;
    public float waitTime;
    private Animator anim;
    public string[] runDirections;
    public GameObject npcDialog;
    private Vector2 pos;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
        anim = GetComponent<Animator>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
        Vector2 direction = moveSpots[randomSpot].position - transform.position;

        if (waitTime == 3) //if npc is moving 
        {
            DirectionToIndex(direction);
            anim.Play(runDirections[DirectionToIndex(direction)]); //play animation
        }
        if (waitTime != 3) // if npc is not moving
        {
            anim.Play(runDirections[4]); //play static sprite
        }


        if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;

            }
            else
            {
                waitTime -= Time.deltaTime;

            }
        }
    }
    //convert moving direction into 4 different directions
    //each direction has different moving animation
    private int DirectionToIndex(Vector2 _direction)
    {
        Vector2 norDir = _direction.normalized;

        float step = 360 / 4; //4 directions in 360degree
        float offset = step / 2;
        float angle = Vector2.SignedAngle(Vector2.up, norDir);

        angle += offset;
        if (angle < 0)
        {
            angle += 360;
        }
        float stepCount = angle / step; //convert into 4 indexes

        return Mathf.FloorToInt(stepCount);


    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        //if door is collision detected
        if (collision.CompareTag("Player"))
        {
            //open door info appear
            npcDialog.SetActive(true);
            infoText.text = "Please keep social distance"; //dialog text
            Vector2 point = cam.WorldToScreenPoint(pos); //transform position from world space to screen space

            npcDialog.transform.position = point + new Vector2(-100.0f, 100.0f); ; //UI display above NPC
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //if door is collision detected
        if (collision.CompareTag("Player"))
        {
            //open door info appear
            npcDialog.SetActive(false);

        }

    }
}
