using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correntAnswers = 0;
    int questionSeen = 0;

    public int GetCorrectAnswers()
    {
        return correntAnswers;
    }

    public void IncrementCorrectAnswers()
    {
        correntAnswers++;
    }

    public int GetQuestionSeen()
    {
        return questionSeen;
    }

    public void IncrementQuestionSeen()
    {
        questionSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt((float)correntAnswers / questionSeen * 100);
    }

}
