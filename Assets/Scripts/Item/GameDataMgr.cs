using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataMgr 
{
    private static GameDataMgr instance = new GameDataMgr();

    public static GameDataMgr Instance => instance;

    public PrankItemSO prankItemSO;

    public ScoreItemSO scoreItemSO;

    public int Score1 = 0;

    public int Score2 = 0;

    private GameDataMgr()
    {

    }
    public void ChangeScore1(int score)
    {
        Score1 += score;
        //更新显示
        GamePanel.Instance.ChangeScore1(Score1);
    }

    public void ChangeScore2(int score)
    {
        Score2 += score;
        //更新显示
        GamePanel.Instance.ChangeScore2(Score2);
    }
}
