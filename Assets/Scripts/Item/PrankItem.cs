using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrankItem : InteractAbleItem
{
    //�ӵ����ͺ�ʹ�õ�����
    [SerializeField] PrankItemSO currentPrankSO;

    public override void BeUsed(Player owner) {
        throw new NotImplementedException();

        if (currentPrankSO == null) {
            Debug.Log("û�����Ƶ��߿���");
            return;
        }

        switch (currentPrankSO.id) {
            case 1:
                // ��ӦIDΪ1�����Ƶ����߼�
                Debug.Log("ʹ�����Ƶ���: " + currentPrankSO.prankItemName);
                // �������IDΪ1�����Ƶ��ߵľ����߼�
                break;
            case 2:
                // ��ӦIDΪ2�����Ƶ����߼�
                Debug.Log("ʹ�����Ƶ���: " + currentPrankSO.prankItemName);
                // �������IDΪ2�����Ƶ��ߵľ����߼�
                break;
            case 3:
                // ��ӦIDΪ3�����Ƶ����߼�
                Debug.Log("ʹ�����Ƶ���: " + currentPrankSO.prankItemName);
                // �������IDΪ2�����Ƶ��ߵľ����߼�
                break;
            case 4:
                // ��ӦIDΪ4�����Ƶ����߼�
                Debug.Log("ʹ�����Ƶ���: " + currentPrankSO.prankItemName);
                // �������IDΪ2�����Ƶ��ߵľ����߼�
                break;
            case 5:
                // ��ӦIDΪ5�����Ƶ����߼�
                Debug.Log("ʹ�����Ƶ���: " + currentPrankSO.prankItemName);
                // �������IDΪ2�����Ƶ��ߵľ����߼�
                break;
            // ������Ҫ��Ӹ���case
            default:
                Debug.Log("δ֪�����Ƶ���ID: " + currentPrankSO.id);
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
            // ������1�Ƿ��Ѿ����е���
            if (HandledZhenggu1.childCount == 0) // ���û���Ӷ�������Լ����µ���
            {
                PickUpItem(HandledZhenggu1);
                //��UI����ʾ
                GamePanel.Instance.ChangeSprite1(currentPrankItem.itemSprite);
            }
            */
        }
        else if (other.gameObject.CompareTag("Player2"))
        {
            /*
            // ������2�Ƿ��Ѿ����е���
            if (HandledZhenggu2.childCount == 0) // ���û���Ӷ�������Լ����µ���
            {
                PickUpItem(HandledZhenggu2);
                //��UI����ʾ
                GamePanel.Instance.ChangeSprite2(currentPrankItem.itemSprite);
            }
            */

        }
    }

    public override void BePicked(Player owner)
    {
        

        throw new NotImplementedException();

        // �����ߵĸ���������Ϊ��ҵ��ֲ�λ��
        transform.SetParent(owner.GetHoldPrankPosition());
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

    public override void BeDropped(Player owner) {
        throw new System.NotImplementedException();
    }
}
