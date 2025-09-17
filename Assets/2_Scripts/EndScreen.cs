using TMPro;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    [SerializeField] ScoreKeeper scoreKeeper;

    public void ShowFinalScore()
    {
        finalScoreText.text = $"�����մϴ�.\r\n" +
            $"����� ������ {scoreKeeper.CalculateScore()}% �Դϴ�.";
    }
}
