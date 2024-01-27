using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScoreItemSO : ScriptableObject
{
    //���߱��
    public int id;
    //��������
    public string itemName;
    //���ߵ÷�
    public int score;
    //ʹ�õ�ͼƬ
    public Sprite itemSprite;
    //���ɺ�����ʧ
    public float lifeTime;
}
