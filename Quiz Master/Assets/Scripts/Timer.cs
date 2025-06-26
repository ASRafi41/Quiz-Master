using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f; 
    [SerializeField] float timeToShowCorrectAnswer = 10f; 
    public bool isAnsweringQuestion = true;
    float timerValue;

    void Update()
    {
        UpdateValue();
    }

    void UpdateValue()
    {
        timerValue -= Time.deltaTime;
        if(isAnsweringQuestion)
        {
            if (timerValue <= 0f)
            {
                timerValue = timeToShowCorrectAnswer;
                isAnsweringQuestion = false;
            }
        }
        else
        {
            if (timerValue <= 0f)
            {
                timerValue = timeToCompleteQuestion; 
                isAnsweringQuestion = true;
                Debug.Log("Ready for the next question.");
            }
        }
        Debug.Log($"Timer Value: {timerValue} seconds remaining.");
    }
}
