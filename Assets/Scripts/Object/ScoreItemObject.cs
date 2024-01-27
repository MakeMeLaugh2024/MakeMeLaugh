using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItemObject : MonoBehaviour
{
    //�ӵ����ͺ�ʹ�õ�����
    public ScoreItemSO info;
    public Transform HandledScore1; // ���1�ֲ���λ�ã���Ҫ�ڱ༭����ָ��
    public Transform HandledScore2; // ���2�ֲ���λ�ã���Ҫ�ڱ༭����ָ��
    public Transform HandledZhenggu1; // ���1�ֲ���λ�ã���Ҫ�ڱ༭����ָ��
    public Transform HandledZhenggu2; // ���2�ֲ���λ�ã���Ҫ�ڱ༭����ָ��


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
            // ������1�Ƿ��Ѿ����е���
            if (HandledZhenggu1.childCount == 0 && HandledScore1.childCount == 0) // ���û���Ӷ�������Լ����µ���
            {
                PickUpItem(HandledScore1);
            }
        }

        else if (other.gameObject.CompareTag("Player2"))
        {
            // ������2�Ƿ��Ѿ����е���
            if (HandledZhenggu2.childCount == 0 && HandledScore2.childCount == 0) // ���û���Ӷ�������Լ����µ���
            {
                PickUpItem(HandledScore2);
            }
        }
    }

    private void PickUpItem(Transform handledScore)
    {
        // �����ߵĸ���������Ϊ��ҵ��ֲ�λ��
        transform.SetParent(handledScore);
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
    }

}
