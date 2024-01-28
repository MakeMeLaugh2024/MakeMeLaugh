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

        // 设置Gizmos的颜色
        Gizmos.color = Color.red;

        // 绘制一个圆圈
        float radius = .3f; // 圆圈的半径，你可以根据需要调整
        Gizmos.DrawWireSphere(checkPosition, radius);
    }
#endif
}
