using UnityEngine;
using System.Collections.Generic; 

[CreateAssetMenu(fileName = "New AudioClipCollection", menuName = "Audio Clip Collection")]
public class AudioClipCollectionSO : ScriptableObject
{
    public List<AudioClipSO> audioClips = new List<AudioClipSO>(); //  π”√List¥Ê¥¢
}
