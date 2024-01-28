using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItem : MonoBehaviour
{
    
    [SerializeField] ScoreItemSO currentScoreSO;

    public void OnTriggerEnter2D(Collider2D collision) {
        Player player = collision.gameObject.GetComponent<Player>();
        Debug.Log(player);
        
        if (player != null && !player.IsHaveScoreItem() ) {
            player.SetScoreItemSO(GetScoreItemSO());

            Destroy(gameObject);
        }
    }

    public ScoreItemSO GetScoreItemSO() {
        return currentScoreSO;
    }
}
