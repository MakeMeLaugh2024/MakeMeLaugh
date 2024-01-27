using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    PlayerControls controls;

    [ControlScheme("LeftKeyboard", "RightKeyboard")]
    [SerializeField] string controlScheme;

    private void Awake() {
        controls = new PlayerControls();
        controls.bindingMask = InputBinding.MaskByGroup(controlScheme);
        controls.Enable();

        controls.Player.Jump.performed += ctx => OnJump();
    }

    public void OnJump() {
        Debug.Log(gameObject + ":Jump");
    }
}
