using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            AudioManager.Instance.sfxController.PlayClip(SfxName.TEST1, transform.position);
        }

        if(Input.GetKeyUp(KeyCode.L))
        {
            AudioManager.Instance.sfxController.PlayClip(SfxName.TEST2, transform.position);
        }
    }
}
