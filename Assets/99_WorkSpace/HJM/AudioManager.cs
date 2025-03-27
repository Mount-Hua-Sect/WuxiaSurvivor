using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    public float masterVolume;
    public float bgmVolume;
    public float sfxVolume;

    private GameObject bgmObject;

    protected override void Initialize()
    {
        bgmObject = new GameObject("bgm Object");
        bgmObject.transform.parent = transform;


    }
}
