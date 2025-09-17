using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string[] answers = new string[4];
    [SerializeField] string question = "여기에 질문을 적어주세요.";
    [SerializeField] int correctAnswerIndex;

    public string GetQuestion()
    {
        return question;
    }
  
    public string GetAnswer(int index)
    {
        return answers[index];
    }

    public string GetCorrectAnswer()
    {
        return answers[correctAnswerIndex];
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

    public void SetData(string q, string[] a, int correctIndex)
    {
        question = q;
        answers = a;
        correctAnswerIndex = correctIndex;
    }
}
