using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    //public AudioSource tickSource;
    public float maxHp = 100.0f;
    public float currentHp = 10.0f;
    public GameObject timer;
    public GameObject resultsCanvas;
    // Start is called before the first frame update
    void Start()
    {
        currentHp = maxHp;
        //tickSource = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Pedestrain"))
        {
            currentHp -= 15.0f;
            //tickSource.Play();
            SoundManager.PlaySound(SoundManager.Sound.HeroHurt);
        }
        //chracter die
        //display endgame scene
        if (currentHp <= 0)
        {
        }
        if (collision.CompareTag("Finish")) {
            resultsCanvas.SetActive(true);
        }
    }

}
