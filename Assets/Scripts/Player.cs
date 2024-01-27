using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))] 
public class Player : MonoBehaviour
{
    [ControlScheme("LeftKeyboard", "RightKeyboard")]
    [SerializeField] string controlScheme;
    [SerializeField] float moveSpeed = 5.0f;
    [SerializeField] float jumpForce = 10.0f;
    [SerializeField] Vector2 checkSize = new Vector2(0.5f, 0.2f);  // 检测的大小，你可以根据需要调整
    [SerializeField] Vector2 checkPositionOffset = Vector2.down * 0.5f;  // 检测的位置偏移，你可以根据需要调整
    [SerializeField] float maxDropSpeed = -10.0f;  // 最大下落速度，你可以根据需要调整

    private PlayerControls controls;
    private Vector2 movement;
    private Rigidbody2D rb;
    private int jumpCount;
    private int jumpCountMax = 2;
    private bool isLeavingGround = false;   

    private void Awake() {
        controls = new PlayerControls();
        controls.bindingMask = InputBinding.MaskByGroup(controlScheme);
        controls.Enable();
        controls.Player.Jump.performed += ctx => OnJump();

        rb = GetComponent<Rigidbody2D>();    
    }
    private void Update() {
        PlayerInput(); 
    }
    private void FixedUpdate() {
        Move();   
    }
    private void PlayerInput() {
        movement = controls.Player.Move.ReadValue<Vector2>();
        jumpCount = IsGrounded() ? 0 : jumpCount;
        rb.velocity = new Vector2(rb.velocity.x, Mathf.Clamp(rb.velocity.y, maxDropSpeed, Mathf.Infinity)); 
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
        rb.AddForce(Vector2.up * (jumpForce / (jumpCount)), ForceMode2D.Impulse);
    }
    private IEnumerator ResetIsLeavingGroundAfterDelay(float delay) {
        yield return new WaitForSeconds(delay);

        // 停止离开地面
        isLeavingGround = false; 
    }

    public void Move() {
        Vector2 newVelocity = movement * moveSpeed;
        newVelocity.y = rb.velocity.y;  // 保持原来的垂直速度，以便受到重力的影响
        rb.velocity = newVelocity;
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
