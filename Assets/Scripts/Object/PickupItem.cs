using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    //������ʱ����Ч
    public GameObject pickupEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //��ʧ��Ч
            Instantiate(pickupEffect, transform.position, Quaternion.identity);
            //������ʧ
            Destroy(this.gameObject);
        }
    }
}
