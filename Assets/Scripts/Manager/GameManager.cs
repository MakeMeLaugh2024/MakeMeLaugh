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
        //������ʾ
        GamePanel.Instance.SetFirstPlayerScore(FirstPlayerScore);
    }

    public void SetSecondPlayerScore(int score)
    {
        SecondPlayerScore += score;
        //������ʾ
        GamePanel.Instance.SetSecondPlayerScore(SecondPlayerScore);
    }
}
