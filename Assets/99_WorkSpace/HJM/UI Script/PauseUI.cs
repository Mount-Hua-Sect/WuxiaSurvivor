using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseUI : BaseUI
{
    [SerializeField] private Button backButton;
    [SerializeField] private Button optionButton;
    [SerializeField] private Button lobbyButton;
    [SerializeField] private Button quitButton;

    public override void InitUI(UIManager uiManager)
    {
        base.InitUI(uiManager);

        backButton.onClick.AddListener(HideUI);
        optionButton.onClick.AddListener(OnOption);
        lobbyButton.onClick.AddListener(OnLobby);
    }

    public override void ShowUI()
    {
        base.ShowUI();
        Time.timeScale = 0;
    }
    public override void HideUI()
    {
        base.HideUI();
        Time.timeScale = 1;
    }

    private void OnOption()
    {
        // Option UI 켜기
        uiManager.optionUI.ShowUI();
    }

    private void OnLobby()
    {
        // Pause UI off
        HideUI();

        // InGameUI off
        uiManager.inGameUI.HideUI();

        // TODO: Scene Loader 유틸 추가
        SceneManager.LoadScene("00_Lobby");
    }
}
