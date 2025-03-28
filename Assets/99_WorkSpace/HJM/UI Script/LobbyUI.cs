using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        SceneManager.LoadScene("01_Main");
    }

    private void OnUpgrade()
    {
        // Upgrade UI 켜기
        uiManager.upgradeUI.ShowUI();
    }

    private void OnOption()
    {
        // Option UI 켜기
        uiManager.optionUI.ShowUI();
    }

    public void UpdateLobbyUI()
    {
        // TODO: 보유중인 Gold 수치 업데이트
        goldText.text = "10000";
    }
}
