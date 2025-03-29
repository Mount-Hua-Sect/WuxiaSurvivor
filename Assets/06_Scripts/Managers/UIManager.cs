using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    public LobbyUI lobbyUI { get; private set; }
    public UpgradeUI upgradeUI { get; private set; }
    public OptionUI optionUI { get; private set; }
    public InGameUI inGameUI { get; private set; }
    public PauseUI pauseUI { get; private set; }



    protected override void Initialize()
    {
        // DontDestroy 설정
        SetDontDestroyOnLoad();

        // UI 생성
        ResourceManager.Instance.Instantiate(Define.CANVAS_KEY, this.transform, Vector2.zero, Vector2.zero);

        // 캐싱
        lobbyUI = FindObjectOfType<LobbyUI>(true);
        upgradeUI = FindObjectOfType<UpgradeUI>(true);
        optionUI = FindObjectOfType<OptionUI>(true);
        inGameUI = FindObjectOfType<InGameUI>(true);
        pauseUI = FindObjectOfType<PauseUI>(true);

        // 초기화
        InitUIs();
    }

    public void InitUIs()
    {
        lobbyUI.InitUI(this);
        upgradeUI.InitUI(this);
        optionUI.InitUI(this);
        inGameUI.InitUI(this);
        pauseUI.InitUI(this);
    }
}
