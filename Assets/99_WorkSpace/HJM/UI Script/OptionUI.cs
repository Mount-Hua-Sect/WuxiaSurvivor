using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionUI : BaseUI
{
    private AudioManager audioManager;

    [Header("Button")]
    [SerializeField] private Button backButton;

    [Header("Sound")]
    [SerializeField] private Slider masterVolumeSlider;
    [SerializeField] private Slider bgmVolumeSlider;
    [SerializeField] private Slider sfxVolumeSlider;
    public override void InitUI(UIManager uiManager)
    {
        base.InitUI(uiManager);
        audioManager = AudioManager.Instance;
        backButton.onClick.AddListener(CloseOption);
    }

    public override void ActiveUI(bool state)
    {
        base.ActiveUI(state);

        masterVolumeSlider.value = audioManager.masterVolume;
        bgmVolumeSlider.value = audioManager.bgmVolume;
        sfxVolumeSlider.value = audioManager.sfxVolume;
    }

    private void CloseOption()
    {
        uiManager.lobbyUI.UpdateLobbyUI();
        // 옵션값 저장
        // TODO: 옵션값 저장

        // UI OFF
        ActiveUI(false);
    }
}
