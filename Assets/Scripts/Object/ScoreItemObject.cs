using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItemObject : MonoBehaviour
{
    //子弹类型和使用的数据
    public ScoreItemSO info;
    public Transform HandledScore1; // 玩家1手部的位置，需要在编辑器中指定
    public Transform HandledScore2; // 玩家2手部的位置，需要在编辑器中指定
    public Transform HandledZhenggu1; // 玩家1手部的位置，需要在编辑器中指定
    public Transform HandledZhenggu2; // 玩家2手部的位置，需要在编辑器中指定


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
        if (other.gameObject.CompareTag("Player1"))
        {
            // 检查玩家1是否已经持有道具
            if (HandledZhenggu1.childCount == 0 && HandledScore1.childCount == 0) // 如果没有子对象，则可以捡起新道具
            {
                PickUpItem(HandledScore1);
            }
        }

        else if (other.gameObject.CompareTag("Player2"))
        {
            // 检查玩家2是否已经持有道具
            if (HandledZhenggu2.childCount == 0 && HandledScore2.childCount == 0) // 如果没有子对象，则可以捡起新道具
            {
                PickUpItem(HandledScore2);
            }
        }
    }

    private void PickUpItem(Transform handledScore)
    {
        // 将道具的父对象设置为玩家的手部位置
        transform.SetParent(handledScore);
        Debug.Log("抓住了");

        // 将道具的局部位置和旋转调整为0，这样它就会位于指定的手部位置
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;

        // 禁用 Rigidbody2D 组件和 Collider2D 组件
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.isKinematic = true; // 将 Rigidbody2D 设置为 Kinematic，阻止物理影响
            rb.velocity = Vector2.zero; // 清除所有当前运动
        }

        Collider2D col = GetComponent<Collider2D>();
        if (col != null)
        {
            col.enabled = false; // 禁用 Collider，防止进一步的碰撞检测
        }
    }

}
