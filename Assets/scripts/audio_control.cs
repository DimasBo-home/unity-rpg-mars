using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_control : MonoBehaviour
{
    public static AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    public static void playClip(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }

}
