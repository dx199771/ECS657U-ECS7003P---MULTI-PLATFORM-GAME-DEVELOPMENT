using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    private static BGM instance = null;
    private AudioSource backgroundmusic;

    private void Awake()
    {
        if (instance == null) //define the situation to activate BGM
        {
            instance = this; //create an instance of the BGM
            DontDestroyOnLoad(gameObject);
            return;
        }
        if (instance == this) return;
        Destroy(gameObject);
    }

    void Start()
    {
        backgroundmusic = GetComponent<AudioSource>(); //show where to obtain the audio clip
        backgroundmusic.Play();
    }
}
