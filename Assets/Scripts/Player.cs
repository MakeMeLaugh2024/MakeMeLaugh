using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerControls controls;
    private Vector2 movement;

    [ControlScheme("LeftKeyboard", "RightKeyboard")]
    [SerializeField] string controlScheme;

    private void Awake() {
        controls = new PlayerControls();
        controls.bindingMask = InputBinding.MaskByGroup(controlScheme);
        controls.Enable();

        controls.Player.Jump.performed += ctx => OnJump();
    }

    private void Update() {
        PlayerInput(); 
    }
    private void FixedUpdate() {
         
    }

    private void PlayerInput() {
        movement = controls.Player.Move.ReadValue<Vector2>();
    }

    public void OnJump() {
        Debug.Log(gameObject + ":Jump");
    }
}
