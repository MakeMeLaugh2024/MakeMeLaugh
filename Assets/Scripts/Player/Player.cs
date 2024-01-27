using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))] 
public class Player : MonoBehaviour, IBuffUser
{
    [ControlScheme("LeftKeyboard", "RightKeyboard")]
    [SerializeField] string controlScheme;
    [SerializeField] float moveSpeed = 5.0f;
    [SerializeField] float jumpForce = 18.0f;
    [SerializeField] Vector2 checkSize = new Vector2(0.5f, 0.2f);  // 检测的大小，你可以根据需要调整
    [SerializeField] Vector2 checkPositionOffset = Vector2.down * 0.5f;  // 检测的位置偏移，你可以根据需要调整
    [SerializeField] float maxDropSpeed = -10.0f;  // 最大下落速度，你可以根据需要调整

    private PlayerControls controls;
    private Vector2 movement;
    private Rigidbody2D rb;
    private int jumpCount;
    private int jumpCountMax = 2;
    private bool isLeavingGround = false;   
    private List<IBuff> buffs = new List<IBuff>();  // 保存所有的Buff
    private List<IBuff> waitToRemove = new List<IBuff>();
    private float gravityScale = 1.0f;
    private bool isFacingRight = true;
    private ScoreItem scoreItem;
    private PrankItem prankItem;

    // IFactor factors
    public float  MoveDirectionFactor { get; set; } = 1.0f;
    public float GravityScaleFactor { get; set; } = 1.0f;
    public float MoveSpeedFactor { get; set; } = 1.0f;
    public float JumpForceFactor { get; set; } = 1.0f;
    public bool CanMoveFlag { get; set; } = true;
    public bool IsSlippery { get; set; }

    public void RemoveBuff(IBuff buff) {
        // 是否已经在等待移除的队列中，并且是否在buffs中
        if (!waitToRemove.Contains(buff) && buffs.Contains(buff))
            waitToRemove.Add(buff);
    }
    public void ApplyBuff(IBuff buff) {
        // 检查是否已经有相同类型的Buff，如果有，就移除掉
        IBuff _buff = null;
        foreach(var b in buffs) {
            if (b.GetType() == buff.GetType()) {
                _buff = b;
                break;
            }
        }
        if (_buff != null) {
            buffs.Remove(_buff);
        }

        buffs.Add(buff);
        buff.Apply(this);
    }

    public void GravityScaleHook() {
        UpdateGravityScale();
    }
    public void UpdateGravityScale() {
        rb.gravityScale = gravityScale * GravityScaleFactor;
    }

    private void Awake() {
        controls = new PlayerControls();
        controls.bindingMask = InputBinding.MaskByGroup(controlScheme);
        controls.Enable();
        controls.Player.Jump.performed += ctx => OnJump();

        rb = GetComponent<Rigidbody2D>();
        gravityScale = rb.gravityScale;
    }
    private void Start() {
        //ApplyBuff(new DirectionReverseBuff(5));
        //ApplyBuff(new ImmobilityBuff(2));
        //ApplyBuff(new GravityChangeBuff(2));

#if UNITY_EDITOR
        controls.Player.BuffTest.performed += ctx => BuffTest((int)ctx.ReadValue<float>());
#endif
    }
    private void Update() {
        PlayerInput(); 
        Move();
        CheckGrounded();

        if (IsSlippery) {
            int direction = isFacingRight ? 1 : -1; 
            rb.velocity = new Vector2(direction * moveSpeed, rb.velocity.y);
        }

        foreach (var buff in buffs) {
            buff.Update(this);
        }
        foreach (var buff in waitToRemove) {
            buffs.Remove(buff);
            Debug.Log("Buff移除: " + buff.GetType().Name);
        }
        waitToRemove.Clear();
    }
    private void PlayerInput() {
        movement = controls.Player.Move.ReadValue<Vector2>();
    }
    private void CheckGrounded() {
        if (IsGrounded()) {
            jumpCount = 0;
            if (!isLeavingGround)
                rb.velocity = new Vector2(rb.velocity.x, 0);
        }
    }
    public void OnJump() {
        jumpCount++;

        // 本次是第jumpCount次跳跃，如果大于最大跳跃次数，就不再跳跃
        if (jumpCount > jumpCountMax) {
            jumpCount = jumpCountMax;
            return;
        }
        // 如果是第一次跳跃，表示正在离开地面
        if (jumpCount == 1) {
            isLeavingGround = true;
            StartCoroutine(ResetIsLeavingGroundAfterDelay(0.1f));
        }

        rb.velocity = new Vector2(rb.velocity.x, 0);
        // 本次跳跃的力度是jumpForce / jumpCount
        rb.AddForce(Vector2.up * (jumpForce * JumpForceFactor / (jumpCount)), ForceMode2D.Impulse);
    }
    private IEnumerator ResetIsLeavingGroundAfterDelay(float delay) {
        yield return new WaitForSeconds(delay);

        // 停止离开地面
        isLeavingGround = false; 
    }


    public void Move() {
        if (IsSlippery) {
            return;
        }

        Vector2 newVelocity = movement * moveSpeed;
        newVelocity.y = rb.velocity.y;  // 保持原来的垂直速度，以便受到重力的影响

        // Caused by buff
        newVelocity.x *= MoveSpeedFactor;
        newVelocity.x *= MoveDirectionFactor;
        newVelocity *= CanMoveFlag ? 1 : 0;
        
        rb.velocity = newVelocity;

        rb.velocity = new Vector2(rb.velocity.x, Mathf.Clamp(rb.velocity.y, maxDropSpeed * GravityScaleFactor, Mathf.Infinity)); 
    }

    public bool IsGrounded() {
        // 如果正在离开地面，就不再检测是否在地面上
        if (isLeavingGround)
            return false;
        
        LayerMask groundLayer = LayerMask.GetMask("Ground");  // 地面的层，你需要在Unity中设置
        // 使用OverlapBox进行覆盖检测
        bool isGrounded = Physics2D.OverlapBox((Vector2)transform.position + checkPositionOffset, checkSize, 0, groundLayer);

        return isGrounded;
    }
    
    void BuffTest(int index) {
        switch (index) {
            case 1:
                ApplyBuff(new DirectionReverseBuff(5));
                Debug.Log("方向反转");
                break;
            case 2:
                ApplyBuff(new GravityChangeBuff(0.5f, 5f));
                Debug.Log("重力变化");
                break;
            case 3:
                ApplyBuff(new ImmobilityBuff(2));
                Debug.Log("禁止移动");
                break;
            case 4:
                ApplyBuff(new SlipperyBuff(2));
                Debug.Log("强制滑行");
                break;
            case 5:
                ApplyBuff(new JumpForceChangeBuff(2, 6));
                Debug.Log("跳跃力变化");
                break;
        } 
    }


    public ScoreItem GetScoreItem() {
        return scoreItem;
    }
    public PrankItem GetPrankItem() {
        return prankItem;
    }
    public void PickScoreItem(ScoreItem scoreItem) {
        if (scoreItem != null) {
            Debug.Log("已经装备得分道具");
            return;
        }
        this.scoreItem = scoreItem;
    }
    public void PickPrankItem(PrankItem prankItem) {
        if (prankItem !=null) {
            Debug.Log("已经装备整蛊道具");
            return;
        }
        this.prankItem = prankItem;
    }
    public void DropPrankItem() {
        if (prankItem != null)
            prankItem = null;
        else
            Debug.Log("没有装备整蛊道具");
    }
    public void DropScoreItem() {
        if (scoreItem != null)
            scoreItem = null;
        else
            Debug.Log("没有装备得分道具");
    }

    public Transform GetHoldScorePosition() {
        throw new NotImplementedException();
    }
    public Transform GetHoldPrankPosition() {
        throw new NotImplementedException();
    }


#if UNITY_EDITOR
    void OnDrawGizmos() {
        Vector2 checkPosition = (Vector2)transform.position + checkPositionOffset;

        // 设置Gizmos的颜色
        Gizmos.color = Color.red;

        // 绘制一个矩形
        Gizmos.DrawWireCube(checkPosition, checkSize);
    }


#endif
}
