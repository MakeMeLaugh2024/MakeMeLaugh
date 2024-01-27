using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    //捡起来时的特效
    public GameObject pickupEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //消失特效
            Instantiate(pickupEffect, transform.position, Quaternion.identity);
            //道具消失
            Destroy(this.gameObject);
        }
    }
}
