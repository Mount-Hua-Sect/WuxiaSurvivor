using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SFXController : MonoBehaviour
{
    // 효과음 범위
    [SerializeField] private float hearingRange = 10;

    private AudioManager audioManager;
    private AudioSource audioSource;
    private AudioListener audioListener;
    private HashSet<AudioClip> playingClips;

    [Header("SFX Clips")]
    [SerializeField] private AudioClip[] clips;
    public void InitController(AudioManager audioManager)
    {
        this.audioManager = audioManager;
        audioSource = gameObject.AddComponent<AudioSource>();
        audioListener = FindObjectOfType<AudioListener>();

        playingClips = new HashSet<AudioClip>();
        foreach (AudioClip clip in clips)
        {
            playingClips.Add(clip);
        }
    }
    public void PlayClip(AudioClip clip, Vector2 sfxPosition)
    {
        // null 예외처리
        if (clip == null) 
            return;

        //  null 예외처리
        if (audioListener == null)
            audioListener = FindObjectOfType<AudioListener>();

        // 범위 밖
        float distance = Vector2.Distance(audioListener.transform.position, sfxPosition);
        if (distance >= hearingRange) 
            return;

        // 이미 재생중인 클립
        if (playingClips.Contains(clip))
            return;

        playingClips.Add(clip);
        audioSource.PlayOneShot(clip, audioManager.volumes[(int)VolumeType.Sfx]);

        StartCoroutine(EndPlayingStatus(clip));
    }

    private IEnumerator EndPlayingStatus(AudioClip clip)
    {
        yield return new WaitForSeconds(clip.length);
        playingClips.Remove(clip);
    }

    private void OnDrawGizmos()
    {
        if (audioListener == null)
            return;

        Gizmos.color = Color.gray;
        Gizmos.DrawWireSphere(audioListener.transform.position, hearingRange);
    }
}
