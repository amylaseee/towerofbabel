using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpatialAudio : MonoBehaviour
{
    public GameObject player;
    public float maxDistance = 90.0f;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.spatialBlend = 1.0f;
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        float volumeMultiplier = 1.0f - Mathf.Clamp01(distance / maxDistance);
        audioSource.volume = volumeMultiplier;
    }
}