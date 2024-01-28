using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetNPC : Singleton<TargetNPC>
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Player player = other.gameObject.GetComponent<Player>();
        if (player != null) {
            ScoreItemSO scoreItemSO = player.GetScoreItemSO();
            if (scoreItemSO != null) {
                player.SetScoreItemSO(null);
                GameManager.Instance.ChangeScoreOfPlayer(player, scoreItemSO.score);
            }
        }
    }
}
