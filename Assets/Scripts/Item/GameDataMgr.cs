using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataMgr : MonoBehaviour
{
    private static GameDataMgr instance = new GameDataMgr();

    public static GameDataMgr Instance => instance;

    public PrankItemSO prankItemSO;

    public ScoreItemSO scoreItemSO;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
