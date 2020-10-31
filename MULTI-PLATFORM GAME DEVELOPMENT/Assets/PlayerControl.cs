using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public AudioSource tickSource;
    public float maxHp = 100.0f;
    public float currentHp = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        currentHp = maxHp;
        tickSource = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Pedestrain"))
        {
            currentHp -= 15.0f;
            tickSource.Play();
        }
        if(currentHp <= 0)
            FindObjectOfType<GameManager>().EndGame();

    }

}
