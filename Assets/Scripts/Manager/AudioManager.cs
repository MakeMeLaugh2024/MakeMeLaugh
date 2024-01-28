using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    public AudioClipCollectionSO audioClipCollection;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AudioPlay(string audioName)
    {
        AudioClipSO clipToPlay = audioClipCollection.audioClips.Find(clip => clip.clipName == audioName);
        if (clipToPlay != null)
        {
            AudioSource.PlayClipAtPoint(clipToPlay.audioClip, Vector3.zero, clipToPlay.volume);
        }
        else
        {
            Debug.LogWarning("Audio clip not found: " + audioName);
        }
    }

}

