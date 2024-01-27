using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItemObject : MonoBehaviour
{
    //�ӵ����ͺ�ʹ�õ�����
    public ScoreItemSO info;
    public Transform HandledScore1; // ���1�ֲ���λ�ã���Ҫ�ڱ༭����ָ��
    public Transform HandledScore2; // ���1�ֲ���λ�ã���Ҫ�ڱ༭����ָ��


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
        Debug.Log("������");

        if (other.gameObject.CompareTag("Player1")) // ȷ��ֻ����ҿ���ʰȡ����
        {
            // �����ߵĸ���������Ϊ��ҵ��ֲ�λ��
            transform.SetParent(HandledScore1);
            Debug.Log("ץס��");
            // �����ߵľֲ�λ�ú���ת����Ϊ0���������ͻ�λ��ָ�����ֲ�λ��
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;

            // ����㲻ϣ�������ڱ�ʰ������������ϵͳ����������������Ӱ�죩�����Խ��� Rigidbody2D ���
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.isKinematic = true; // �� Rigidbody2D ����Ϊ Kinematic����ֹ����Ӱ��
                rb.velocity = Vector2.zero; // ������е�ǰ�˶�
            }

            // ����� Collider ��������㲻ϣ��������ʰȡ��������������������ײ�����Խ��� Collider ���
            Collider2D col = GetComponent<Collider2D>();
            if (col != null)
            {
                col.enabled = false; // ���� Collider����ֹ��һ������ײ���
            }
        }

        if (other.gameObject.CompareTag("Player2")) // ȷ��ֻ����ҿ���ʰȡ����
        {
            // �����ߵĸ���������Ϊ��ҵ��ֲ�λ��
            transform.SetParent(HandledScore2);
            Debug.Log("ץס��");
            // �����ߵľֲ�λ�ú���ת����Ϊ0���������ͻ�λ��ָ�����ֲ�λ��
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;

            // ����㲻ϣ�������ڱ�ʰ������������ϵͳ����������������Ӱ�죩�����Խ��� Rigidbody2D ���
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.isKinematic = true; // �� Rigidbody2D ����Ϊ Kinematic����ֹ����Ӱ��
                rb.velocity = Vector2.zero; // ������е�ǰ�˶�
            }

            // ����� Collider ��������㲻ϣ��������ʰȡ��������������������ײ�����Խ��� Collider ���
            Collider2D col = GetComponent<Collider2D>();
            if (col != null)
            {
                col.enabled = false; // ���� Collider����ֹ��һ������ײ���
            }
        }
    }

}
