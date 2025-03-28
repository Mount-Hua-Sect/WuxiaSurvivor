using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionUI : BaseUI
{
    private AudioManager audioManager;

    [Header("Button")]
    [SerializeField] private Button backButton;

    [Header("Slider")]
    [SerializeField] private Slider masterVolumeSlider;
    [SerializeField] private Slider bgmVolumeSlider;
    [SerializeField] private Slider sfxVolumeSlider;

    public override void InitUI(UIManager uiManager)
    {
        base.InitUI(uiManager);
        audioManager = AudioManager.Instance;
        backButton.onClick.AddListener(HideUI);

        masterVolumeSlider.onValueChanged.AddListener(
             value => audioManager.SetVolume(VolumeType.Master, value));
        bgmVolumeSlider.onValueChanged.AddListener(
            value => audioManager.SetVolume(VolumeType.Bgm, value));
        sfxVolumeSlider.onValueChanged.AddListener(
            value => audioManager.SetVolume(VolumeType.Sfx, value));
    }

    public override void ShowUI()
    {
        base.ShowUI();

        float[] volumes = audioManager.volumes;
        masterVolumeSlider.value = volumes[(int)VolumeType.Master];
        bgmVolumeSlider.value = volumes[(int)VolumeType.Bgm];
        sfxVolumeSlider.value = volumes[(int)VolumeType.Sfx];
    }

    public override void HideUI()
    {
        base.HideUI();

        // Lobby UI 업데이트
        uiManager.lobbyUI.UpdateLobbyUI("로비");

        // 볼륨값 저장
        audioManager.SaveVolumes();
    }
}
