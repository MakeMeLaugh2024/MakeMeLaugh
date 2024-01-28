using UnityEngine;

public class JumpForceChangeBuff : IBuff {
    private float duration = 5f;
    private float targetFactor;
    public float Duration {
        get { return duration; }
        set { duration = value; }
    }  // buff的持续时间

    private float timer = 0f;  // buff的计时器

    public void Apply(IBuffUser obj) {
        obj.JumpForceFactor = targetFactor;
        Debug.Log("跳跃力变化");
    }

    public void Remove(IBuffUser obj) {
        obj.JumpForceFactor = 1f;
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

    public JumpForceChangeBuff(float targetFactor, float duration = 5f) {
        this.targetFactor = targetFactor;
        this.duration = duration;
    }
    public void SetTimer(float timer) {
        this.timer = timer;
    }
}