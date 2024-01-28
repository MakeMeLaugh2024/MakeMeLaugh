using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<RespawnPoint> spawnPoints;
    [SerializeField] private Player firstPlayer;
    [SerializeField] private Player secondPlayer;
    // 生成道具的比例，越大越容易生产得分道具而越不容易生产恶作剧道具 
    [SerializeField] private float scoreItemRatio = .3f;
    // 生产道具的概率
    [SerializeField] private float respawnRatio = .3f;
    // 询问生成的间隔
    [SerializeField] private float respawnInterval = 1f;

    private static GameManager instance;
    public static GameManager Instance => instance;

    public PrankItemCollectionSO prankItemCollectionSO;

    public ScoreItemCollectionSO scoreItemCollectionSO;

    public int FirstPlayerScore = 0;

    public int SecondPlayerScore = 0;

    private void Start() {
        StartCoroutine(RandomRespawnItem());
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
        //������ʾ
        GamePanel.Instance.SetFirstPlayerScore(FirstPlayerScore);
    }

    public void SetSecondPlayerScore(int score)
    {
        SecondPlayerScore = score;
        //������ʾ
        GamePanel.Instance.SetSecondPlayerScore(SecondPlayerScore);
    }

    public Player GetEnemyPlayer(Player player) {
        if (player == firstPlayer)
            return secondPlayer;
        else if (player == secondPlayer)
            return firstPlayer;
        else
            throw new System.Exception("��Ҳ�����");
    }

}
