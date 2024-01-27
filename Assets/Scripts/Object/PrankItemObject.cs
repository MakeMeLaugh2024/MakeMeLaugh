using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrankItemObject : MonoBehaviour
{
    //�ӵ����ͺ�ʹ�õ�����
    public PrankItemSO info;
    public Transform HandledZhenggu1; // ���1�ֲ���λ�ã���Ҫ�ڱ༭����ָ��
    public Transform HandledZhenggu2; // ���1�ֲ���λ�ã���Ҫ�ڱ༭����ָ��


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
            if (HandledZhenggu1.childCount == 0) // ���û���Ӷ�������Լ����µ���
            {
                PickUpItem(HandledZhenggu1);
                //��UI����ʾ
                GamePanel.Instance.ChangeSprite1(info.itemSprite);
            }
        }
        else if (other.gameObject.CompareTag("Player2"))
        {
            // ������2�Ƿ��Ѿ����е���
            if (HandledZhenggu2.childCount == 0) // ���û���Ӷ�������Լ����µ���
            {
                PickUpItem(HandledZhenggu2);
                //��UI����ʾ
                GamePanel.Instance.ChangeSprite2(info.itemSprite);
            }
        }
    }

    private void PickUpItem(Transform handledPrank)
    {
        // �����ߵĸ���������Ϊ��ҵ��ֲ�λ��
        transform.SetParent(handledPrank);
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

        //���ɼ�
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.enabled = false;
        }
    }
}