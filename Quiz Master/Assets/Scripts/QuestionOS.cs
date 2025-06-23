using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionOS : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] public string questionText = "Enter new question text here";
    [SerializeField] string[] answers = new string[4] { "Answer 1", "Answer 2", "Answer 3", "Answer 4" };
    [SerializeField] int correctAnswerIndex = 0; // Index of the correct answer in the answers array

    public string GetQuestionText()
    {
        return questionText;
    }

    public string[] GetAnswers()
    {
        return answers;
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }
}
