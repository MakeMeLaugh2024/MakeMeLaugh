using UnityEngine;

public class ControlSchemeAttribute : PropertyAttribute {
    public string[] controlSchemes;

    public ControlSchemeAttribute(params string[] controlSchemes) {
        this.controlSchemes = controlSchemes;
    }
}