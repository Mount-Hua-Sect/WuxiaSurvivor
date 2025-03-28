using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BGMController : MonoBehaviour
{
    private AudioManager audioManager;
    private AudioSource audioSource;

    public void InitController(AudioManager audioManager)
    {
        this.audioManager = audioManager;
        transform.parent = audioManager.transform;

        audioSource = GetComponent<AudioSource>();
    }
}