using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TestManager : MonoBehaviour
{
    public TextMeshProUGUI questionText;
    public TMP_InputField userGuess;
    private int currentIndex = 0;

    void Start()
    {
        ShowCurrentQuestion();
    }

    void ShowCurrentQuestion()
    {
        if (questionstorage.masterDeck.Count > currentIndex)
        {
            questionText.text = questionstorage.masterDeck[currentIndex].question;
        }
        else
        {
            questionText.text = "All Done! Go back to menu.";
        }
    }

    public void CheckAnswer()
    {
        string correct = questionstorage.masterDeck[currentIndex].answer.Trim().ToLower();
        string input = userGuess.text.Trim().ToLower();

        if (input == correct)
        {
            currentIndex++;
            userGuess.text = "";
            ShowCurrentQuestion();
        }
        else
        {
            // This is the important part for your timer!
            questionstorage.wrongAnswersCount++;
            userGuess.text = "";
        }
    }

    public void FinishAndGoHome()
    {
        SceneManager.LoadScene(0);
    }
}