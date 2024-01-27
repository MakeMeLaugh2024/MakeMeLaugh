using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("碰到玩家了");
        // 检测碰撞到的对象是否是玩家
        if (other.gameObject.CompareTag("Player1"))
        {
            Debug.Log("碰到玩家1了");
            // 尝试在玩家对象中找到名为 "HandledScore" 的子物体
            Transform handleScore = other.gameObject.transform.Find("HandledScore");

            if (handleScore != null)
            {
                Debug.Log("有子物体");
                // 遍历 HandledScore 下的所有子物体
                foreach (Transform child in handleScore)
                {
                    // 尝试获取 ScoreItemObject 脚本
                    ScoreItemObject scoreItem = child.GetComponent<ScoreItemObject>();

                    if (scoreItem != null)
                    {
                        // 存在 ScoreItemObject，打印其 info 中的 score 值
                        Debug.Log("Score1: " + scoreItem.info.score + "猫咪吃到了" + scoreItem.info.itemName + "非常高兴");

                        // 销毁含有 ScoreItemObject 脚本的 GameObject
                        Destroy(child.gameObject);
                    }
                }
            }
        }

        if (other.gameObject.CompareTag("Player2"))
        {
            Debug.Log("碰到玩家2了");
            // 尝试在玩家对象中找到名为 "HandledScore" 的子物体
            Transform handleScore = other.gameObject.transform.Find("HandledScore");

            if (handleScore != null)
            {
                // 遍历 HandleScore 下的所有子物体
                foreach (Transform child in handleScore)
                {
                    // 尝试获取 ScoreItemObject 脚本
                    ScoreItemObject scoreItem = child.GetComponent<ScoreItemObject>();

                    if (scoreItem != null)
                    {
                        // 存在 ScoreItemObject，打印其 info 中的 score 值
                        Debug.Log("Score2:" + scoreItem.info.score + "猫咪吃到了" + scoreItem.info.itemName + "非常高兴");

                        // 销毁含有 ScoreItemObject 脚本的 GameObject
                        Destroy(child.gameObject);
                    }
                }
            }
        }
    }
}
