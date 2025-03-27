using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeUI : BaseUI
{
    [Header("Button")]
    [SerializeField] private Button backButton;

    public override void InitUI(UIManager uiManager)
    {
        base.InitUI(uiManager);

        backButton.onClick.AddListener(CloseUpgrade);
    }

    private void CloseUpgrade()
    {
        uiManager.lobbyUI.UpdateLobbyUI();
        // UI OFF
        ActiveUI(false);
    }
}
