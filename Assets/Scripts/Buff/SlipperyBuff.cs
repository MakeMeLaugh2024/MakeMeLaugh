using UnityEngine;

public class SlipperyBuff : IBuff {
    private float duration = 2f;
    public float Duration {
        get { return duration; }
        set { duration = value; }
    }  // buff�ĳ���ʱ��

    private float timer = 0f;  // buff�ļ�ʱ��

    public void Apply(IBuffUser obj) {
        Player player = obj as Player;
        // ���в��ܴ�
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