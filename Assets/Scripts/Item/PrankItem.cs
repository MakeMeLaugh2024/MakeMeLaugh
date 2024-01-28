using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class PrankItem : MonoBehaviour{
    //子弹类型和使用的数据
    [SerializeField] PrankItemSO currentPrankSO;

    private List<IBuff> buffs = new List<IBuff>();
    private bool isInited = false;

    public void OnTriggerEnter2D(Collider2D collision) {
        Player player = collision.gameObject.GetComponent<Player>();

        if (player != null && !player.IsHavePrankItem()) {
            player.SetPrankItemSO(GetPrankItemSO());

            Destroy(gameObject);
        }
    }
    public void SetPrankItemSO(PrankItemSO prankItemSO) {
        currentPrankSO = prankItemSO; 
    }
    public void Init() {
        if (isInited)
            return;

        switch (currentPrankSO.prankType) {
            case PrankItemType.Feather:
                buffs.Add(new GravityChangeBuff(0.5f, 3f));
                buffs.Add(new JumpForceChangeBuff(1.2f, 3f));
                break;
            case PrankItemType.Hammer:
                buffs.Add(new ImmobilityBuff(2f));
                break;
            case PrankItemType.Slime:
                buffs.Add(new SpeedChangedBuff(0.5f, 4f));
                break;
            case PrankItemType.Posion:
                buffs.Add(new DirectionReverseBuff(4f));
                break;
            case PrankItemType.Tornado:
                buffs.Add(new HoverBuff(2f));
                break;
        }
        isInited = true;
    }
    public PrankItemSO GetPrankItemSO() {
        return currentPrankSO;
    }
    public void UseTo(Player player) {
        if (!isInited)
            Init();
        Debug.Log("添加buff" + buffs.Count);
        foreach (var buff in buffs) {
            player.ApplyBuff(buff);
        }

        switch (currentPrankSO.prankType) {
            case PrankItemType.Feather:
                break;
            case PrankItemType.Hammer:
                //打落对面得分道具
                player.SetScoreItemSO(null);
                break;
            case PrankItemType.Slime:
                break;
            case PrankItemType.Posion:
                break;
            case PrankItemType.Tornado:
                //打落对面恶作剧道具
                player.SetPrankItemSO(null);
                break;
        }
        GameObject objVFX = Instantiate(currentPrankSO.PrankVFX, player.transform.position, Quaternion.identity);
        Debug.Log(objVFX.name);
        Destroy(gameObject);
    }
}
