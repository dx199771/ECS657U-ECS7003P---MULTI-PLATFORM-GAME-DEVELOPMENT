using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour 
{
    private static GameAssets _Instance;

    public static GameAssets Instance
    {
        get
        {
            if (_Instance == null) _Instance = (Instantiate(Resources.Load("GameAssets")) as GameObject).GetComponent<GameAssets>(); //Create a new instance if there isn't one
            return _Instance;

        }
    }

    public SoundAudioClip[] soundAudioClipArray; //create an array for sound effect audio clip

    [System.Serializable]
    public class SoundAudioClip
    {
        public SoundManager.Sound sound;
        public AudioClip audioClip;

    }
}
