using UnityEngine;

public class SpeedChangedBuff : IBuff {
    private float duration = 5f;
    private float targetFactor;
    public float Duration {
        get { return duration; }
        set { duration = value; }
    }  // buff的持续时间

    private float timer = 0f;  // buff的计时器

    public void Apply(IBuffUser obj) {
        obj.MoveSpeedFactor = targetFactor;
    }

    public void Remove(IBuffUser obj) {
        obj.MoveSpeedFactor = 1f;
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

    public SpeedChangedBuff(float targetFactor, float duration = 5f) {
        this.targetFactor = targetFactor;
    }
    public void SetTimer(float timer) {
        this.timer = timer;
    }
}