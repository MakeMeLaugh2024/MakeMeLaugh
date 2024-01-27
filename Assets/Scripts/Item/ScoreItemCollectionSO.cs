using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScoreItemCollectionSO : ScriptableObject
{
    public List<ScoreItemSO> props = new List<ScoreItemSO>();
}

