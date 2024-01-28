using UnityEngine;
using TMPro; // ���� TextMeshPro �����ռ�

public class ScorePanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI firstPlayerScoreText; // ��һλ��ҷ�����ʾ�� TextMeshPro ���
    [SerializeField] private TextMeshProUGUI secondPlayerScoreText; // �ڶ�λ��ҷ�����ʾ�� TextMeshPro ���

    private GameManager gameManager; // GameManager ������

    private void Start()
    {
        gameManager = GameManager.Instance; // ��ȡ GameManager �ĵ���ʵ��
        UpdateScoreDisplay(); // ��ʼʱ���·�����ʾ

        // ���ķ����仯�¼�
        gameManager.OnScoreChanged += (sender, e) => UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        // ���� TextMeshPro �ı��������ʾ��ǰ����
        firstPlayerScoreText.text = "" + gameManager.FirstPlayerScore.ToString();
        secondPlayerScoreText.text = "" + gameManager.SecondPlayerScore.ToString();
    }

    private void OnDestroy()
    {
        // ȡ�������¼�����ֹ�ڴ�й©
        if (gameManager != null)
        {
            gameManager.OnScoreChanged -= (sender, e) => UpdateScoreDisplay();
        }
    }
}
