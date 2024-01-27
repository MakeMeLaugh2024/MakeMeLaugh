using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScoreItem Collection", fileName = "New ScoreItemCollection")]
public class ScoreItemCollection : ScriptableObject
{
    public List<ScoreItemSO> props = new List<ScoreItemSO>();
}

