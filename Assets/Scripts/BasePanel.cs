using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ������ ������� ����̳��� �������ǵ�ʹ�� ��Լ������
/// </summary>
public abstract class BasePanel<T> : MonoBehaviour where T : class
{
    private static T instance;

    //�������ԣ����ڷ��ʵ�����ʵ��
    public static T Instance => instance;//

    protected virtual void Awake()
    {
        instance = this as T;
    }

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    public abstract void Init();

    //��Ҫ���ڳ�ʼ��������

    public virtual void ShowMe()
    {
        Debug.Log("������");
        this.gameObject.SetActive(true);
    }

    public virtual void HideMe()
    {
        this.gameObject.SetActive(false);
    }
}
