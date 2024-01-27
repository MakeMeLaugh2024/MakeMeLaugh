using UnityEngine;

public class SlipperyBuff : IBuff {
    private float duration = 2f;
    public float Duration {
        get { return duration; }
        set { duration = value; }
    }  // buff的持续时间

    private float timer = 0f;  // buff的计时器

    public void Apply(IBuffUser obj) {
        Player player = obj as Player;
        // 空中不能打滑
        if (player != null && player.IsGrounded()) {
            obj.IsSlippery = true;
            obj.SlipperyHook(); 
        }
    }

    public void Remove(IBuffUser obj) {
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

    public SlipperyBuff(float duration = 5f) {
        this.duration = duration;
    }
}