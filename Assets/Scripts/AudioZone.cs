using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioZone : MonoBehaviour
{
    public AudioMixerSnapshot snapshot1;
    public AudioMixerSnapshot snapshot2;

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            snapshot1.TransitionTo(1f);
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            snapshot2.TransitionTo(1f);
        }
    }

}
