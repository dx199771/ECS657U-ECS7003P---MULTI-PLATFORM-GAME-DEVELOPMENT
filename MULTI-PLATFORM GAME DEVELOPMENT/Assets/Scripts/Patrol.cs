using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public Transform[] moveSpots;
    private int randomSpot;
    public float startWaitTime;
    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
        Vector2 direction = moveSpots[randomSpot].position - transform.position;
        
        FindObjectOfType<PlayerAnimation>().SetDirection(direction); //assign animation to the character according to the direction

        //Vector2 direction = new Vector2(horAxis, verAxis);
        //FindObjectOfType<PlayerAnimation>().SetDirection(direction);

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
}
