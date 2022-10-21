using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPrefab : MonoBehaviour
{
    public AudioSource m_MyAudioSource;
    
    void OnTriggerEnter(Collider other)
    {
        if ( other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            m_MyAudioSource.Play();
        }
    }
}


