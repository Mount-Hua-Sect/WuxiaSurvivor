using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour
{
    AudioManager audioManager;
    public void InitController(AudioManager audioManager)
    {
        this.audioManager = audioManager;
    }
}
