using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrankItem : InteractAbleItem
{
    //子弹类型和使用的数据
    [SerializeField] PrankItemSO currentPrankSO;

    public override void BeUsed(Player owner) {
        throw new NotImplementedException();

        if (currentPrankSO == null) {
            Debug.Log("没有整蛊道具可用");
            return;
        }

        switch (currentPrankSO.id) {
            case 1:
                // 对应ID为1的整蛊道具逻辑
                Debug.Log("使用整蛊道具: " + currentPrankSO.prankItemName);
                // 这里添加ID为1的整蛊道具的具体逻辑
                break;
            case 2:
                // 对应ID为2的整蛊道具逻辑
                Debug.Log("使用整蛊道具: " + currentPrankSO.prankItemName);
                // 这里添加ID为2的整蛊道具的具体逻辑
                break;
            case 3:
                // 对应ID为3的整蛊道具逻辑
                Debug.Log("使用整蛊道具: " + currentPrankSO.prankItemName);
                // 这里添加ID为2的整蛊道具的具体逻辑
                break;
            case 4:
                // 对应ID为4的整蛊道具逻辑
                Debug.Log("使用整蛊道具: " + currentPrankSO.prankItemName);
                // 这里添加ID为2的整蛊道具的具体逻辑
                break;
            case 5:
                // 对应ID为5的整蛊道具逻辑
                Debug.Log("使用整蛊道具: " + currentPrankSO.prankItemName);
                // 这里添加ID为2的整蛊道具的具体逻辑
                break;
            // 根据需要添加更多case
            default:
                Debug.Log("未知的整蛊道具ID: " + currentPrankSO.id);
                break;
        }
    }


    //public void InitInfo(ScoreItemSO info)
    //{
    //    this.info = info;

    //    Invoke("DelayDestroy", info.lifeTime);
    //}

    /*
    private void DelayDestroy()
    {
        Dead();
    }
    */

    public void Dead()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        throw new NotImplementedException();
        if (other.gameObject.CompareTag("Player1"))
        {
            /*
            // 检查玩家1是否已经持有道具
            if (HandledZhenggu1.childCount == 0) // 如果没有子对象，则可以捡起新道具
            {
                PickUpItem(HandledZhenggu1);
                //在UI中显示
                GamePanel.Instance.ChangeSprite1(currentPrankItem.itemSprite);
            }
            */
        }
        else if (other.gameObject.CompareTag("Player2"))
        {
            /*
            // 检查玩家2是否已经持有道具
            if (HandledZhenggu2.childCount == 0) // 如果没有子对象，则可以捡起新道具
            {
                PickUpItem(HandledZhenggu2);
                //在UI中显示
                GamePanel.Instance.ChangeSprite2(currentPrankItem.itemSprite);
            }
            */

        }
    }

    public override void BePicked(Player owner)
    {
        

        throw new NotImplementedException();

        // 将道具的父对象设置为玩家的手部位置
        transform.SetParent(owner.GetHoldPrankPosition());
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

        //不可见
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.enabled = false;
        }
    }

    public override void BeDropped(Player owner) {
        throw new System.NotImplementedException();
    }
}
