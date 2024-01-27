using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PrankItemSO : ScriptableObject
{
    //如果是整蛊类道具，用于分辨的id
    public int id;
    //道具的名字
    public string propName;
    //道具使用的图片
    public Sprite itemSprite;
}
