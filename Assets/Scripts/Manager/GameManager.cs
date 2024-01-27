using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance => instance;

    //public PrankItemSO prankItemSO;

    //public ScoreItemSO scoreItemSO;

    public int FirstPlayerScore = 0;

    public int SecondPlayerScore = 0;

    public void SetFirstPlayerScore(int score)
    {
        FirstPlayerScore += score;
        //更新显示
        GamePanel.Instance.SetFirstPlayerScore(FirstPlayerScore);
    }

    public void SetSecondPlayerScore(int score)
    {
        SecondPlayerScore += score;
        //更新显示
        GamePanel.Instance.SetSecondPlayerScore(SecondPlayerScore);
    }
}
