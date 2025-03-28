using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCanvas : MonoBehaviour
{
    // UIManager를 호출할곳이없어서 임시로 호출용으로 만든 스크립트 입니다.
    // 나중에 옮겨야해요

    void Awake()
    {
        UIManager tmp = UIManager.Instance;
        transform.parent = tmp.transform;
    }
}
