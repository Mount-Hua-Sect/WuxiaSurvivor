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

    /*
     * 효과음
     * HashSet 사용해서 중복 효과음 방지
     * 플레이어와 일정거리 떨어져있을경우  효과음 X
     * 
     * 배경음
     * 배경음 페이드인 페이드아웃
     */
    protected override void Initialize()
    {
        // DontDestroy 설정
        SetDontDestroyOnLoad();

        // volume 불러오기
        LoadVolumes();

        // BGM object 생성
        bgmObject = new GameObject("bgm Object");
        bgmObject.transform.parent = transform;
    }

    /// <summary>
    /// Volume 불러오기
    /// </summary>
    private void LoadVolumes()
    {
        volumes = new float[3];
        volumes[(int)VolumeType.Master] = PlayerPrefs.GetFloat(masterVolumeKey, 0.5f);
        volumes[(int)VolumeType.Bgm] = PlayerPrefs.GetFloat(bgmVolumeKey, 0.5f);
        volumes[(int)VolumeType.Sfx] = PlayerPrefs.GetFloat(sfxVolumeKey, 0.5f);
    }

    /// <summary>
    /// Volume 저장
    /// </summary>
    public void SaveVolumes()
    {
        PlayerPrefs.SetFloat(masterVolumeKey, volumes[(int)VolumeType.Master]);
        PlayerPrefs.SetFloat(bgmVolumeKey, volumes[(int)VolumeType.Bgm]);
        PlayerPrefs.SetFloat(sfxVolumeKey, volumes[(int)VolumeType.Sfx]);
    }

    /// <summary>
    /// Volume 값 수정 메서드
    /// </summary>
    /// <param name="type">변경할 Volume Type</param>
    /// <param name="value">값</param>
    public void SetVolume(VolumeType type, float value)
    {
        volumes[(int)type] = value;
    }
}
