using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUI : MonoBehaviour
{
    protected UIManager uiManager;

    public virtual void InitUI(UIManager uiManager)
    {
        this.uiManager = uiManager;
    }

    public virtual void ActiveUI(bool state)
    {
        gameObject.SetActive(state);
    }
}
