using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chlipTriger : MonoBehaviour
{
    [SerializeField]
    private AudioClip clip;

    void OnTriggerEnter(Collider other)
    {
        audio_control.playClip(clip);
    }
}
