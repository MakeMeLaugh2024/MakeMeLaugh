public interface IBuff {
    float Duration { get; set; }
    void Apply(IBuffUser obj);
    void Remove(IBuffUser obj);
    void Update(IBuffUser obj); 
}