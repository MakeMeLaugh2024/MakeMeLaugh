using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AudioClip", menuName = "Audio Clip")]
public class AudioClipSO : ScriptableObject
{
    public string clipName;
    public float volume = 1.0f;
    public AudioClip audioClip;
}

