using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItem : InteractAbleItem
{
    //�ӵ����ͺ�ʹ�õ�����
    public ScoreItemSO currentScoreSO;
    //public Transform HandledScore1; // ���1�ֲ���λ�ã���Ҫ�ڱ༭����ָ��
    //public Transform HandledScore2; // ���1�ֲ���λ�ã���Ҫ�ڱ༭����ָ��

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
        /*
        if (other.gameObject.CompareTag("Player1"))
        {
            // ������1�Ƿ��Ѿ����е���
            if (HandledScore1.childCount == 0) // ���û���Ӷ�������Լ����µ���
            {
                PickUpItem(HandledScore1);
            }
        }
        else if (other.gameObject.CompareTag("Player2"))
        {
            // ������2�Ƿ��Ѿ����е���
            if (HandledScore2.childCount == 0) // ���û���Ӷ�������Լ����µ���
            {
                PickUpItem(HandledScore2);
            }
        }
        */
    }

    public override void BePicked(Player owner)
    {
        throw new NotImplementedException();
        /*
        // �����ߵĸ���������Ϊ��ҵ��ֲ�λ��
        transform.SetParent(owner.GetHoldScorePosition());
        Debug.Log("ץס��");

        // �����ߵľֲ�λ�ú���ת����Ϊ0���������ͻ�λ��ָ�����ֲ�λ��
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;

        // ���� Rigidbody2D ����� Collider2D ���
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.isKinematic = true; // �� Rigidbody2D ����Ϊ Kinematic����ֹ����Ӱ��
            rb.velocity = Vector2.zero; // ������е�ǰ�˶�
        }

        Collider2D col = GetComponent<Collider2D>();
        if (col != null)
        {
            col.enabled = false; // ���� Collider����ֹ��һ������ײ���
        }
        */
    }

    public override void BeDropped(Player owner) {
        throw new NotImplementedException();
    }

    public override void BeUsed(Player owner) {
        throw new NotImplementedException();
    }

    public ScoreItemSO GetScoreItemSO() {
        return currentScoreSO;
    }
}
