using UnityEngine;
using TMPro; // 引入 TextMeshPro 命名空间

public class ScorePanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI firstPlayerScoreText; // 第一位玩家分数显示的 TextMeshPro 组件
    [SerializeField] private TextMeshProUGUI secondPlayerScoreText; // 第二位玩家分数显示的 TextMeshPro 组件

    private GameManager gameManager; // GameManager 的引用

    private void Start()
    {
        gameManager = GameManager.Instance; // 获取 GameManager 的单例实例
        UpdateScoreDisplay(); // 初始时更新分数显示

        // 订阅分数变化事件
        gameManager.OnScoreChanged += (sender, e) => UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        // 更新 TextMeshPro 文本组件以显示当前分数
        firstPlayerScoreText.text = "" + gameManager.FirstPlayerScore.ToString();
        secondPlayerScoreText.text = "" + gameManager.SecondPlayerScore.ToString();
    }

    private void OnDestroy()
    {
        // 取消订阅事件，防止内存泄漏
        if (gameManager != null)
        {
            gameManager.OnScoreChanged -= (sender, e) => UpdateScoreDisplay();
        }
    }
}
