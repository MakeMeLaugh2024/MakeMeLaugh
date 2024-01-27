using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePank : MonoBehaviour
{
    // 当前玩家持有的道具
    public PrankItemSO currentPrankItem;

    void UsePrankItem()
    {
        if (currentPrankItem == null)
        {
            Debug.Log("没有整蛊道具可用");
            return;
        }

        switch (currentPrankItem.id)
        {
            case 1:
                // 对应ID为1的整蛊道具逻辑
                Debug.Log("使用整蛊道具: " + currentPrankItem.prankItemName);
                // 这里添加ID为1的整蛊道具的具体逻辑
                break;
            case 2:
                // 对应ID为2的整蛊道具逻辑
                Debug.Log("使用整蛊道具: " + currentPrankItem.prankItemName);
                // 这里添加ID为2的整蛊道具的具体逻辑
                break;
            case 3:
                // 对应ID为3的整蛊道具逻辑
                Debug.Log("使用整蛊道具: " + currentPrankItem.prankItemName);
                // 这里添加ID为2的整蛊道具的具体逻辑
                break;
            case 4:
                // 对应ID为4的整蛊道具逻辑
                Debug.Log("使用整蛊道具: " + currentPrankItem.prankItemName);
                // 这里添加ID为2的整蛊道具的具体逻辑
                break;
            case 5:
                // 对应ID为5的整蛊道具逻辑
                Debug.Log("使用整蛊道具: " + currentPrankItem.prankItemName);
                // 这里添加ID为2的整蛊道具的具体逻辑
                break;
            // 根据需要添加更多case
            default:
                Debug.Log("未知的整蛊道具ID: " + currentPrankItem.id);
                break;
        }
    }

    void Prank1()
    {

    }
    // 假设我们通过按下键盘上的一个键来使用整蛊道具
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J)) // 按U使用整蛊道具
        {
            UsePrankItem();
        }
    }
}

