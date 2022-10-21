using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioZone2 : MonoBehaviour
{
    
    public AudioMixerSnapshot snapshot3;
    
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            snapshot3.TransitionTo(0f);
        }
    }
}
