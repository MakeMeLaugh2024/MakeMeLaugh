using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScoreItemCollection : ScriptableObject
{
    public List<ScoreItemSO> props = new List<ScoreItemSO>();
}

