using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbyUI : BaseUI
{
    [Header("Lobby Data")]
    [SerializeField] private TextMeshProUGUI uiTitle;

    [Header("Button")]
    [SerializeField] private Button startButton;
    [SerializeField] private Button upgradeButton;
    [SerializeField] private Button optionButton;

    public override void InitUI(UIManager uiManager)
    {
        base.InitUI(uiManager);

        startButton.onClick.AddListener(HideUI);
        upgradeButton.onClick.AddListener(OnUpgrade);
        optionButton.onClick.AddListener(OnOption);

        UpdateLobbyUI("로비");
    }

    public override void HideUI()
    {
        base.HideUI();

        // TODO: Main 씬 이동 추가하기
        SceneManager.LoadScene("01_Main");
    }

    private void OnUpgrade()
    {
        // Upgrade UI 켜기
        uiManager.upgradeUI.ShowUI();
        UpdateLobbyUI("강화");
    }

    private void OnOption()
    {
        // Option UI 켜기
        uiManager.optionUI.ShowUI();
        UpdateLobbyUI("설정");
    }

    public void UpdateLobbyUI(string title)
    {
        uiTitle.text = title;
    }
}
