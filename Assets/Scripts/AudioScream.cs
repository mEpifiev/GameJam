using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AudioScream : MonoBehaviour
{
    [SerializeField] private AudioClip[] audioClips;
    [SerializeField] private AudioSource audioSource;

    private bool activeAudio = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!activeAudio && other.CompareTag("Player"))
        {
            audioSource.clip = audioClips[Random.Range(0, audioClips.Length)];
            audioSource.Play();
            StartCoroutine(Timer());
        }
    }

    private IEnumerator Timer()
    {
        activeAudio = true;
        yield return new WaitForSeconds(8);
        activeAudio = false;
    }
}