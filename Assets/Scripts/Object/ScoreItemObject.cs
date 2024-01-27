using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItemObject : MonoBehaviour
{
    //子弹类型和使用的数据
    public ScoreItemSO info;
    public Transform HandledScore1; // 玩家1手部的位置，需要在编辑器中指定
    public Transform HandledScore2; // 玩家1手部的位置，需要在编辑器中指定


    //public void InitInfo(ScoreItemSO info)
    //{
    //    this.info = info;

    //    Invoke("DelayDestroy", info.lifeTime);
    //}

    private void DelayDestroy()
    {
        Dead();
    }

    public void Dead()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("碰到了");

        if (other.gameObject.CompareTag("Player1")) // 确保只有玩家可以拾取道具
        {
            // 将道具的父对象设置为玩家的手部位置
            transform.SetParent(HandledScore1);
            Debug.Log("抓住了");
            // 将道具的局部位置和旋转调整为0，这样它就会位于指定的手部位置
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;

            // 如果你不希望道具在被拾起后继续与物理系统交互（比如受重力影响），可以禁用 Rigidbody2D 组件
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.isKinematic = true; // 将 Rigidbody2D 设置为 Kinematic，阻止物理影响
                rb.velocity = Vector2.zero; // 清除所有当前运动
            }

            // 如果有 Collider 组件并且你不希望道具在拾取后继续与其他对象产生碰撞，可以禁用 Collider 组件
            Collider2D col = GetComponent<Collider2D>();
            if (col != null)
            {
                col.enabled = false; // 禁用 Collider，防止进一步的碰撞检测
            }
        }

        if (other.gameObject.CompareTag("Player2")) // 确保只有玩家可以拾取道具
        {
            // 将道具的父对象设置为玩家的手部位置
            transform.SetParent(HandledScore2);
            Debug.Log("抓住了");
            // 将道具的局部位置和旋转调整为0，这样它就会位于指定的手部位置
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;

            // 如果你不希望道具在被拾起后继续与物理系统交互（比如受重力影响），可以禁用 Rigidbody2D 组件
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.isKinematic = true; // 将 Rigidbody2D 设置为 Kinematic，阻止物理影响
                rb.velocity = Vector2.zero; // 清除所有当前运动
            }

            // 如果有 Collider 组件并且你不希望道具在拾取后继续与其他对象产生碰撞，可以禁用 Collider 组件
            Collider2D col = GetComponent<Collider2D>();
            if (col != null)
            {
                col.enabled = false; // 禁用 Collider，防止进一步的碰撞检测
            }
        }
    }

}
