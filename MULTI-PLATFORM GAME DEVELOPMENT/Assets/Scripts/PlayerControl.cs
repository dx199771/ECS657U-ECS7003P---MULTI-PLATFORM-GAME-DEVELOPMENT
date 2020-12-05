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
    public Text hpText;
    // Start is called before the first frame update
    void Start()
    {
        currentHp = maxHp;
        //tickSource = GetComponent<AudioSource>();

    }
    void Update()
    {
        //update hp text
        hpText.text = ""+ currentHp+ "%";

    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("PedestrainInner"))
        {
            currentHp -= 15.0f;
            //tickSource.Play();
            SoundManager.PlaySound(SoundManager.Sound.HeroHurt);
        }
        //chracter die
        //display endgame scene
        if (currentHp <= 0)
        {
            resultsCanvas.SetActive(true);
        }
        if (collision.CompareTag("Finish")) {
            resultsCanvas.SetActive(true);
        }
    }

}
