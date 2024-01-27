using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetNPC : MonoBehaviour
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
                    ScoreItem scoreItem = child.GetComponent<ScoreItem>();

                    if (scoreItem != null)
                    {
                        // ���� ScoreItemObject����ӡ�� GetScoreItemSO() �е� score ֵ
                        Debug.Log("Score1: " + scoreItem.GetScoreItemSO().score + "è��Ե���" + scoreItem.GetScoreItemSO().itemName + "�ǳ�����");

                        //�ӷ���
                        GameManager.Instance.SetFirstPlayerScore(scoreItem.GetScoreItemSO().score);

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
                    ScoreItem scoreItem = child.GetComponent<ScoreItem>();

                    if (scoreItem != null)
                    {
                        // ���� ScoreItemObject����ӡ�� GetScoreItemSO() �е� score ֵ
                        Debug.Log("Score2:" + scoreItem.GetScoreItemSO().score + "è��Ե���" + scoreItem.GetScoreItemSO().itemName + "�ǳ�����");

                        //�ӷ���
                        GameManager.Instance.SetSecondPlayerScore(scoreItem.GetScoreItemSO().score);

                        // ���ٺ��� ScoreItemObject �ű��� GameObject
                        Destroy(child.gameObject);
                    }
                }
            }
        }
    }
}
