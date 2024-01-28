using UnityEngine;

public class GravityChangeBuff : IBuff {
    private float duration = 5f;
    private float targetFactor;
    public float Duration {
        get { return duration; }
        set { duration = value; }
    }  // buff的持续时间

    private float timer = 0f;  // buff的计时器

    public void Apply(IBuffUser obj) {
        obj.GravityScaleFactor = targetFactor;
        obj.GravityScaleHook(); 

        Debug.Log("方向反向");
    }

    public void Remove(IBuffUser obj) {
        obj.GravityScaleFactor = 1f;
        obj.GravityScaleHook();
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

    public void SetTimer(float timer) {
        this.timer = timer;
    }

    public GravityChangeBuff(float targetFactor, float duration=5f) {
        this.targetFactor = targetFactor;
        this.duration = duration;
    }
}