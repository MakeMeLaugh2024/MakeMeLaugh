using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PrankItemSO : ScriptableObject
{
    //�������������ߣ����ڷֱ��id
    public int id;
    //���ߵ�����
    public string prankItemName;
    //����ʹ�õ�ͼƬ
    public Sprite itemSprite;
    //���ɺ�����ʧ
    public float lifeTime;
    public PrankItemType prankType;
    public GameObject prefab;
}
