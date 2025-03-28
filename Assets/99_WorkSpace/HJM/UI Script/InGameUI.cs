using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUI : BaseUI
{
    [SerializeField] private ExpBar expbar;
    [SerializeField] private GameTimer gameTimer;

    public override void InitUI(UIManager uiManager)
    {
        base.InitUI(uiManager);

        // 초기화
        expbar.InitExpBar();
        gameTimer.InitTimer();
    }

    public override void ShowUI()
    {
        base.ShowUI();


    }
}