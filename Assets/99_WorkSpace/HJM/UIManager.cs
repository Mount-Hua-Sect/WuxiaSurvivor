using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIManager : Singleton<UIManager>
{
    public LobbyUI lobbyUI;
    public UpgradeUI upgradeUI;
    public OptionUI optionUI;

    protected override void Initialize()
    {
        // DontDestroy 설정
        SetDontDestroyOnLoad();

        // 캐싱
        lobbyUI = FindObjectOfType<LobbyUI>(true);
        upgradeUI = FindObjectOfType<UpgradeUI>(true);
        optionUI = FindObjectOfType<OptionUI>(true);

        // 초기화
        lobbyUI.InitUI(this);
        upgradeUI.InitUI(this);
        optionUI.InitUI(this);
    }
}
