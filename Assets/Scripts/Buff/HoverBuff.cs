using UnityEngine;

public class HoverBuff : IBuff {
    private float duration = 5f;
    public float Duration {
        get { return duration; }
        set { duration = value; }
    }  // buff�ĳ���ʱ��

    private float timer = 0f;  // buff�ļ�ʱ��


    public void Apply(IBuffUser obj) {
        Debug.Log(this.ToString() + duration);
        obj.HoverHook(duration, this);
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
    public void SetTimer(float timer) {
        this.timer = timer;
    }
    public float GetTimer() {
        return timer;
    }

    public HoverBuff(float duration = 5f) {
        this.duration = duration;
    }
}