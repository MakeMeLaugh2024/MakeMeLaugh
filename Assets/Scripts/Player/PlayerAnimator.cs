using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] Animator animator;

    private void Start() {
        player.OnStateChanged += (sender, e) => {
            UpdateState(e.stateType);
        };
    }
    public void UpdateState(StateType state) {
        foreach (var s in System.Enum.GetValues(typeof(StateType))) {
            animator.SetBool(s.ToString(), false);
        }

        animator.SetBool(state.ToString(), true); 
    }  
}
