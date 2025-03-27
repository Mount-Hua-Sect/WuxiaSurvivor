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

        startButton.onClick.AddListener(OnStart);
        upgradeButton.onClick.AddListener(OnUpgrade);
        optionButton.onClick.AddListener(OnOption);
    }

    private void OnStart()
    {
        // Lobby UI Off
        ActiveUI(false);

        // Main Scene 이동
        // 대충 씬 이동 코드 어쩌구 저쩌구
    }

    private void OnUpgrade()
    {
        uiManager.upgradeUI.ActiveUI(true);
    }

    private void OnOption()
    {
        uiManager.optionUI.ActiveUI(true);
    }

    public void UpdateLobbyUI()
    {
        // 1. gold 업데이트
    }
}
