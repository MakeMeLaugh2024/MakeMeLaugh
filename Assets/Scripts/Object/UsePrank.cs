using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePank : MonoBehaviour
{
    // ��ǰ��ҳ��еĵ���
    public PrankItemSO currentPrankItem;

    void UsePrankItem()
    {
        if (currentPrankItem == null)
        {
            Debug.Log("û�����Ƶ��߿���");
            return;
        }

        switch (currentPrankItem.id)
        {
            case 1:
                // ��ӦIDΪ1�����Ƶ����߼�
                Debug.Log("ʹ�����Ƶ���: " + currentPrankItem.prankItemName);
                // �������IDΪ1�����Ƶ��ߵľ����߼�
                break;
            case 2:
                // ��ӦIDΪ2�����Ƶ����߼�
                Debug.Log("ʹ�����Ƶ���: " + currentPrankItem.prankItemName);
                // �������IDΪ2�����Ƶ��ߵľ����߼�
                break;
            case 3:
                // ��ӦIDΪ3�����Ƶ����߼�
                Debug.Log("ʹ�����Ƶ���: " + currentPrankItem.prankItemName);
                // �������IDΪ2�����Ƶ��ߵľ����߼�
                break;
            case 4:
                // ��ӦIDΪ4�����Ƶ����߼�
                Debug.Log("ʹ�����Ƶ���: " + currentPrankItem.prankItemName);
                // �������IDΪ2�����Ƶ��ߵľ����߼�
                break;
            case 5:
                // ��ӦIDΪ5�����Ƶ����߼�
                Debug.Log("ʹ�����Ƶ���: " + currentPrankItem.prankItemName);
                // �������IDΪ2�����Ƶ��ߵľ����߼�
                break;
            // ������Ҫ��Ӹ���case
            default:
                Debug.Log("δ֪�����Ƶ���ID: " + currentPrankItem.id);
                break;
        }
    }

    void Prank1()
    {

    }
    // ��������ͨ�����¼����ϵ�һ������ʹ�����Ƶ���
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J)) // ��Uʹ�����Ƶ���
        {
            UsePrankItem();
        }
    }
}

