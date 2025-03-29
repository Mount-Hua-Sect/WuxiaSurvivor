using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePopup : MonoBehaviour
{
    private PoolManager poolManager;

    public void InitDamagePopup()
    {
        poolManager = PoolManager.Instance;
    }
}
