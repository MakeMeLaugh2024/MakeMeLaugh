using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePanel : BasePanel<GamePanel>
{
    public Button btnQuit;

    public List<GameObject> hpObjs1;

    public List<GameObject> hpObjs2;

    public Image PrankSprite1;

    public Image PrankSprite2;

    public override void Init()
    {
        btnQuit.onClick.AddListener(() =>
        {
            Debug.Log("开始游戏啦");
            SceneManager.LoadScene("BeginScene");
        });
    }

    public void ChangeScore1(int hp)
    {
        Debug.Log("现在1分数是" + hp);
        for (int i = 0; i < hpObjs1.Count; i++)
        {
            hpObjs1[i].SetActive(i < hp);
        }
    }

    public void ChangeScore2(int hp)
    {
        for (int i = 0; i < hpObjs2.Count; i++)
        {
            hpObjs2[i].SetActive(i < hp);
        }
    }

    public void ChangeSprite1(Sprite sprite)
    {
        PrankSprite1.sprite = sprite;
    }

    public void ChangeSprite2(Sprite sprite)
    {
        PrankSprite2.sprite = sprite;
    }


}
