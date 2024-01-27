using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PrankItemCollection", fileName = "New PrankItemSOCollection")]
public class PrankItemCollection : ScriptableObject
{
    public List<PrankItemSO> props = new List<PrankItemSO>();
}

