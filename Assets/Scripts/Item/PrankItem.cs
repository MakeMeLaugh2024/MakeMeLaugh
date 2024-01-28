using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class PrankItem : MonoBehaviour{
    //子弹类型和使用的数据
    [SerializeField] PrankItemSO currentPrankSO;

    private List<IBuff> buffs = null;

    public void OnTriggerEnter2D(Collider2D collision) {
        Player player = collision.gameObject.GetComponent<Player>();

        if (player != null && !player.IsHavePrankItem()) {
            player.SetPrankItemSO(GetPrankItemSO());

            Destroy(gameObject);
        }
    }
    public void Init() {
        if (buffs != null)
            return;

        switch (currentPrankSO.prankType) {
            case PrankItemType.Feather:
                buffs.Add(new GravityChangeBuff(0.5f, 5f));
                buffs.Add(new JumpForceChangeBuff(1.2f, 5f));
                break;
            case PrankItemType.Hammer:
                buffs.Add(new ImmobilityBuff(2f));
                break;
            case PrankItemType.Silme:
                buffs.Add(new SpeedChangedBuff(0.5f, 5f));
                break;
            case PrankItemType.Posion:
                buffs.Add(new DirectionReverseBuff(5f));
                break;
            case PrankItemType.Tornado:
                break;
        }
    }
    public PrankItemSO GetPrankItemSO() {
        return currentPrankSO;
    }
}
