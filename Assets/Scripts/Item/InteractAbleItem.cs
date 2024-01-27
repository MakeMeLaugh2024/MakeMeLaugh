using UnityEngine;

public abstract class InteractAbleItem : MonoBehaviour{
    private Player owner;
    public abstract void BePicked(Player owner);
    public abstract void BeDropped(Player owner);
    public abstract void BeUsed(Player owner);
}