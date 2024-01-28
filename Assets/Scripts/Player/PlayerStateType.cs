using System;

public enum StateType { 
    Idle,
    Run,
    Jump,
    Down,
    Slippy
}
public class StateTypeEventArgs : EventArgs {
    public StateType stateType;
    public StateTypeEventArgs(StateType stateType) {
        this.stateType = stateType;
    }
}
