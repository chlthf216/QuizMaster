using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float problemTime = 10f;
    [SerializeField] float solutionTIme = 3f;
    float time = 0;

    [HideInInspector] public bool isProblemTime = true;
    [HideInInspector] public float fillAmount;
    [HideInInspector] public bool loadNextQuestion;

    private void Start()
    {
        time = problemTime;

    }

    private void Update()
    {
        TimerCountDown();
        UpdateFillAmount();

    }

    private void UpdateFillAmount()
    {
        if (isProblemTime)
            fillAmount = time / problemTime;
        else
            fillAmount = time / solutionTIme;
    }

    private void TimerCountDown()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            if (isProblemTime)
            {
                isProblemTime = false;
                time = solutionTIme;
            }
            else
            {
                isProblemTime = true;
                time = problemTime;
                loadNextQuestion = true;
            }

        }
    }

    public void CancelTimer()
    {
        time = 0;
    }

}
