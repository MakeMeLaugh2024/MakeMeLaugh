using UnityEngine;

public class DirectionReverseBuff : IBuff {
    private float duration = 5f;
    public float Duration {
        get { return duration; }
        set { duration = value; }
    }  // buff的持续时间

    private float timer = 0f;  // buff的计时器


    public void Apply(IBuffUser obj) {
        obj.MoveDirectionFactor = -1f;
        Debug.Log("方向反向");
    }

    public void Remove(IBuffUser obj) {
        obj.MoveDirectionFactor = 1f;
        obj.RemoveBuff(this);
    }

    public void Update(IBuffUser obj){
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

    public DirectionReverseBuff(float duration = 5f) {
        this.duration = duration;
    }
}