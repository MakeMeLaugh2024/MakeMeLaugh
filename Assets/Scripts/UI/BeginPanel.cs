using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BeginPanel : BasePanel<BeginPanel>
{
    public Button btnStart;
    public Button btnQuit;



    public override void Init()
    {
        btnStart.onClick.AddListener(() =>
        {
            Debug.Log("开始游戏啦");
            SceneManager.LoadScene("Main");
        });

        btnQuit.onClick.AddListener(() =>
        {
            Application.Quit();
            Debug.Log("退出");
        });


    }



}
