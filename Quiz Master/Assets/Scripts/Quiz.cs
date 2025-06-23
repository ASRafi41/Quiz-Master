using UnityEngine;
using TMPro;

public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionOS question;
    void Start()
    {
        questionText.text = question.GetQuestionText();
    }
}
