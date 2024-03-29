using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using Random = UnityEngine.Random;

public class GameManager : Singleton<GameManager> {
    public event EventHandler OnScoreChanged;

    [SerializeField] TextMeshProUGUI WinTest;
    [SerializeField] List<RespawnPoint> spawnPoints;
    [SerializeField] private Player firstPlayer;
    [SerializeField] private Player secondPlayer;
    // 生成道具的比例，越大越容易生产得分道具而越不容易生产恶作剧道具 
    [SerializeField] private float scoreItemRatio = .3f;
    // 生产道具的概率
    [SerializeField] private float respawnRatio = .3f;
    // 询问生成的间隔
    [SerializeField] private float respawnInterval = 1f;
    // 胜利要达到的分数
    [SerializeField] private float winScore = 10f;

    public PrankItemCollectionSO prankItemCollectionSO;

    public ScoreItemCollectionSO scoreItemCollectionSO;

    public int FirstPlayerScore { get; private set; }

    public int SecondPlayerScore { get; private set; }

    private void Start() {
        StartCoroutine(RandomRespawnItem());
        OnScoreChanged += (sender, e) => ScoreTest();
    }
    private void ScoreTest() {
        Debug.Log("Frist:" + FirstPlayerScore + "Second:" + SecondPlayerScore);
    }

    private IEnumerator RandomRespawnItem() {
        while(gameObject.activeSelf == true) {
            GameObject itemNeedToRespawn = null;
            // 一秒询问一次 
            yield return new WaitForSeconds(respawnInterval);
            // 是否要生成?
            if (Random.value < respawnRatio) {
                // 生产哪一个
                if(Random.value < scoreItemRatio) {
                    itemNeedToRespawn = scoreItemCollectionSO.props[Random.Range(0, scoreItemCollectionSO.props.Count)].prefab;
                } else {
                    itemNeedToRespawn = prankItemCollectionSO.props[Random.Range(0, prankItemCollectionSO.props.Count)].prefab; 
                }
                
                // 生成在哪里
                RespawnPoint respawnPoint = spawnPoints[Random.Range(0, spawnPoints.Count)];

                if (itemNeedToRespawn != null)
                    respawnPoint.TryRespawnOne(itemNeedToRespawn);
            }
        }
    }

    public void SetFirstPlayerScore(int score)
    {
        FirstPlayerScore = score;
        OnScoreChanged?.Invoke(this, EventArgs.Empty);

        if (score < 0)
            score = 0;
        if (score > winScore)
            WhoWin(firstPlayer);
    }

    public void SetSecondPlayerScore(int score)
    {
        SecondPlayerScore = score;
        OnScoreChanged?.Invoke(this, EventArgs.Empty);

        if (score < 0)
            score = 0;
        if (score > winScore)
            WhoWin(secondPlayer);
    }

    public Player GetEnemyPlayer(Player player) {
        if (player == firstPlayer)
            return secondPlayer;
        else if (player == secondPlayer)
            return firstPlayer;
        else
            throw new System.Exception("Player not found");
    }
    public void ChangeScoreOfPlayer(Player player, int delta) {
        if (player == firstPlayer)
            SetFirstPlayerScore(FirstPlayerScore + delta);
        else if (player == secondPlayer)
            SetSecondPlayerScore(SecondPlayerScore + delta);
        else
            throw new System.Exception("Player not found");
    } 
    public void WhoWin(Player player) {
        Debug.Log(player.name + "win");
        WinTest.gameObject.SetActive(true);
        if (player == firstPlayer)
            WinTest.text = "Player 1 win";
        else if (player == secondPlayer)
            WinTest.text = "Player 2 win";
        else
            throw new System.Exception("Player not found");
    }
}
