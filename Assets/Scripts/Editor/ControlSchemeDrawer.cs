#if UNITY_EDITOR
using System;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(ControlSchemeAttribute))]
public class ControlSchemeDrawer : PropertyDrawer {
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
        ControlSchemeAttribute controlSchemeAttribute = (ControlSchemeAttribute)attribute;
        int index = Mathf.Max(0, Array.IndexOf(controlSchemeAttribute.controlSchemes, property.stringValue));
        index = EditorGUI.Popup(position, label.text, index, controlSchemeAttribute.controlSchemes);
        property.stringValue = controlSchemeAttribute.controlSchemes[index];
    }
}
#endif