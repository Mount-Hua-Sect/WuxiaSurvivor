using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXController : MonoBehaviour
{
    AudioManager audioManager;
    public void InitController(AudioManager audioManager)
    {
        this.audioManager = audioManager;
    }
}
