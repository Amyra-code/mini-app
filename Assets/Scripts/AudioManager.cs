using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource sfxSource;
    public AudioClip coinClip;

    private void Awake()
    {
        instance = this;
    }

    public void PlayCoin()
    {
        sfxSource.PlayOneShot(coinClip);
    }
}
