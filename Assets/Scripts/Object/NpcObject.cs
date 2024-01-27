using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("���������");
        // �����ײ���Ķ����Ƿ������
        if (other.gameObject.CompareTag("Player1"))
        {
            Debug.Log("�������1��");
            // ��������Ҷ������ҵ���Ϊ "HandledScore" ��������
            Transform handleScore = other.gameObject.transform.Find("HandledScore");

            if (handleScore != null)
            {
                Debug.Log("��������");
                // ���� HandledScore �µ�����������
                foreach (Transform child in handleScore)
                {
                    // ���Ի�ȡ ScoreItemObject �ű�
                    ScoreItemObject scoreItem = child.GetComponent<ScoreItemObject>();

                    if (scoreItem != null)
                    {
                        // ���� ScoreItemObject����ӡ�� info �е� score ֵ
                        Debug.Log("Score1: " + scoreItem.info.score + "è��Ե���" + scoreItem.info.itemName + "�ǳ�����");

                        // ���ٺ��� ScoreItemObject �ű��� GameObject
                        Destroy(child.gameObject);
                    }
                }
            }
        }

        if (other.gameObject.CompareTag("Player2"))
        {
            Debug.Log("�������2��");
            // ��������Ҷ������ҵ���Ϊ "HandledScore" ��������
            Transform handleScore = other.gameObject.transform.Find("HandledScore");

            if (handleScore != null)
            {
                // ���� HandleScore �µ�����������
                foreach (Transform child in handleScore)
                {
                    // ���Ի�ȡ ScoreItemObject �ű�
                    ScoreItemObject scoreItem = child.GetComponent<ScoreItemObject>();

                    if (scoreItem != null)
                    {
                        // ���� ScoreItemObject����ӡ�� info �е� score ֵ
                        Debug.Log("Score2:" + scoreItem.info.score + "è��Ե���" + scoreItem.info.itemName + "�ǳ�����");

                        // ���ٺ��� ScoreItemObject �ű��� GameObject
                        Destroy(child.gameObject);
                    }
                }
            }
        }
    }
}
