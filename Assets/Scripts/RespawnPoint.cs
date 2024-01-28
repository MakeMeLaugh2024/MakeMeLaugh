using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    private GameObject currentObj;

    public void TryRespawnOne(GameObject objNeedToRespawn) {
        if (IsHadOne() || objNeedToRespawn == null)
            return;

        GameObject gameObject = Instantiate(objNeedToRespawn, transform.position, Quaternion.identity);
        currentObj = gameObject;
    }
    public void DestroyCurrentObj() {
        if (IsHadOne()) {
            Destroy(currentObj);
            currentObj = null;
        }
    }
    public bool IsHadOne() {
        return currentObj != null;
    }
#if UNITY_EDITOR
    void OnDrawGizmos() {
        Vector2 checkPosition = (Vector2)transform.position;

        // ����Gizmos����ɫ
        Gizmos.color = Color.red;

        // ����һ��ԲȦ
        float radius = .3f; // ԲȦ�İ뾶������Ը�����Ҫ����
        Gizmos.DrawWireSphere(checkPosition, radius);
    }
#endif
}
