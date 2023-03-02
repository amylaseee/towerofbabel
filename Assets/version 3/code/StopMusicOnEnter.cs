using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusicOnEnter : MonoBehaviour
{
    public GameObject musicObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioSource audioSource = musicObject.GetComponent<AudioSource>();
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
