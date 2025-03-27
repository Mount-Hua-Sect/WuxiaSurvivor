using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LobbyUI : BaseUI
{
    [Header("Lobby Data")]
    [SerializeField] private TextMeshProUGUI goldText;

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
    }

    public override void HideUI()
    {
        base.HideUI();

        // TODO: Main 씬 이동 추가하기
    }

    private void OnUpgrade()
    {
        uiManager.upgradeUI.ShowUI();
    }

    private void OnOption()
    {
        uiManager.optionUI.ShowUI();
    }

    public void UpdateLobbyUI()
    {
        // 1. gold 업데이트
    }
}
