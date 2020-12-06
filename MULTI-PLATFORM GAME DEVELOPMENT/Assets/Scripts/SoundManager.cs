using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundManager
{
    public enum Sound
    {
        HeroHurt,
        HeroMove,
        PickItem,
        DropItem,
        PayBill,
        DogBark,
        GooseHonk,
        SwitchScene,
    }

    private static Dictionary<Sound, float> soundTimerDictionary;

    public static void Initialize()
    {
        soundTimerDictionary = new Dictionary<Sound, float>();
        soundTimerDictionary[Sound.HeroMove] = 0f;
        soundTimerDictionary[Sound.DogBark] = 0f;
        soundTimerDictionary[Sound.GooseHonk] = 0f;
    }

    public static void PlaySound(Sound sound)
    {
        if (CanPlaySound(sound)) 
        {
            GameObject soundGameObject = new GameObject("Sound");
            AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
            audioSource.PlayOneShot(GetAudioClip(sound));
        }
        
    }

    private static bool CanPlaySound(Sound sound) //To set a limit for how frequently a sound can play.
    {
        switch (sound)
        {
            default:
                return true; //buy default, a sound can play as frequent as it wants
            case Sound.HeroMove: // set a separate case for the footstep sound of the hero.
                if (soundTimerDictionary.ContainsKey(sound))
                {
                    float lastTimePlayed = soundTimerDictionary[sound];
                    float playerMoveTimerMax = .35f;
                    if(lastTimePlayed + playerMoveTimerMax < Time.time) // if more than 0.35 second from last time play the foot step sound
                    {
                        soundTimerDictionary[sound] = Time.time; // update the last time played with the current time
                        return true; //allow the sound being played
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            case Sound.DogBark: // set a separate case for the dog barking sound
                if (soundTimerDictionary.ContainsKey(sound))
                {
                    float lastTimeBarked = soundTimerDictionary[sound];
                    //float dogBarkTimerMax = new Random.Range(10f,30f);
                    float dogBarkTimerMax = 10f;
                    if (lastTimeBarked + dogBarkTimerMax < Time.time) // if the current time surpass the threshold set 
                    {
                        soundTimerDictionary[sound] = Time.time; // update the last time played with the current time
                        return true; //allow the sound being played
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
                
        }
    }

    private static AudioClip GetAudioClip(Sound sound)
    {
        foreach (GameAssets.SoundAudioClip soundAudioClip in GameAssets.Instance.soundAudioClipArray)
        {
            if (soundAudioClip.sound == sound)
            {
                return soundAudioClip.audioClip;
            }
        }
        Debug.LogError("Sound" + sound + "Not Found!");
            return null;
    }
}
