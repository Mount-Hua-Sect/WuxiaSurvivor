using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public enum VolumeType
{
    Master,
    Bgm,
    Sfx
}

public class AudioManager : Singleton<AudioManager>
{
    // player prefs key
    private const string masterVolumeKey = "masterVolume";
    private const string bgmVolumeKey = "bgmVolume";
    private const string sfxVolumeKey = "sfxVolume";

    // volumes
    public float[] volumes { get; private set; }

    // bgm object
    private GameObject bgmObject;

    // sfx object

    protected override void Initialize()
    {
        SetDontDestroyOnLoad();

        LoadVolumes();

        bgmObject = new GameObject("bgm Object");
        bgmObject.transform.parent = transform;
    }

    private void LoadVolumes()
    {
        volumes = new float[3];
        volumes[(int)VolumeType.Master] = PlayerPrefs.GetFloat(masterVolumeKey, 0.5f);
        volumes[(int)VolumeType.Bgm] = PlayerPrefs.GetFloat(bgmVolumeKey, 0.5f);
        volumes[(int)VolumeType.Sfx] = PlayerPrefs.GetFloat(sfxVolumeKey, 0.5f);
    }

    public void SaveVolumes()
    {
        PlayerPrefs.SetFloat(masterVolumeKey, volumes[(int)VolumeType.Master]);
        PlayerPrefs.SetFloat(bgmVolumeKey, volumes[(int)VolumeType.Bgm]);
        PlayerPrefs.SetFloat(sfxVolumeKey, volumes[(int)VolumeType.Sfx]);
    }

    public void SetVolume(VolumeType type, float value)
    {
        volumes[(int)type] = value;
    }
}
