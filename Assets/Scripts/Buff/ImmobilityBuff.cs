using UnityEngine;

public class ImmobilityBuff : IBuff {
    private float duration = 5f;
    public float Duration {
        get { return duration; }
        set { duration = value; }
    }  // buff的持续时间

    private float timer = 0f;  // buff的计时器

    public void Apply(IBuffUser obj) {
        obj.CanMoveFlag = false;
    }

    public void Remove(IBuffUser obj) {
        obj.CanMoveFlag = true;
        obj.RemoveBuff(this);
    }

    public void Update(IBuffUser obj) {
        timer += Time.deltaTime;
        if (timer >= duration) {
            Remove(obj);
        }
    }

    public void ResetTimer() {
        timer = 0f;
    }

    public ImmobilityBuff(float duration=5f) {
        this.duration = duration;
    }
}