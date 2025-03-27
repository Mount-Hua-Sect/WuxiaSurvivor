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
        // Main Scene 이동
    }

    private void OnUpgrade()
    {
        uiManager.upgradeUI.ActiveUI(true);
    }

    private void OnOption()
    {
        uiManager.optionUI.ActiveUI(true);
    }
}
