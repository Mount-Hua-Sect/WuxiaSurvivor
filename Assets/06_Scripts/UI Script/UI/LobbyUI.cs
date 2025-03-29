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

        ShowUI();
    }

    public override void ShowUI()
    {
        base.ShowUI();
        UpdateLobbyTitle("로비");
    }

    public override void HideUI()
    {
        base.HideUI();

        uiManager.inGameUI.ShowUI();
        SceneManager.LoadScene("01_Main");
    }

    private void OnUpgrade()
    {
        // Upgrade UI ON
        uiManager.upgradeUI.ShowUI();
        UpdateLobbyTitle("강화");
    }

    private void OnOption()
    {
        // Option UI ON
        uiManager.optionUI.ShowUI();
        UpdateLobbyTitle("설정");
    }

    public void UpdateLobbyTitle(string title)
    {
        uiTitle.text = title;
    }
}
