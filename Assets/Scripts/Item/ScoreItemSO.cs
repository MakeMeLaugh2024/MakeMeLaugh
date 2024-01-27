using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScoreItemSO : ScriptableObject
{
    //道具名称
    public string itemName;
    //道具得分
    public int score;
    //使用的图片
    public Sprite itemSprite;

}
