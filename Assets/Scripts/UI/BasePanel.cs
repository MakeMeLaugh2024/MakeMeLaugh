using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 面板基类 所有面板 都会继承它 方便我们的使用 节约代码量
/// </summary>
public abstract class BasePanel<T> : MonoBehaviour where T : class
{
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    public abstract void Init();

    //主要用于初始化监听等

    public virtual void ShowMe()
    {
        this.gameObject.SetActive(true);
    }

    public virtual void HideMe()
    {
        this.gameObject.SetActive(false);
    }
}
