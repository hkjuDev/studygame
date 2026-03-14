using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class savequestion : MonoBehaviour
{
    public TMP_InputField inputQ;
    public TMP_InputField inputA;

    public void savequetsion()
    {
        if (!string.IsNullOrEmpty(inputQ.text) && !string.IsNullOrEmpty(inputA.text))
        {
            questionstorage.StudyPair newPair = new questionstorage.StudyPair();
            newPair.question = inputQ.text;
            newPair.answer = inputA.text;

            questionstorage.masterDeck.Add(newPair);

            // Sync the count to the vault for the timer to see
            questionstorage.totalQuestionsCount = questionstorage.masterDeck.Count;

            inputQ.text = "";
            inputA.text = "";
        }
    }

    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }
    public void ResetAllData()
    {
        questionstorage.masterDeck.Clear();
        questionstorage.totalQuestionsCount = 0;
        questionstorage.wrongAnswersCount = 0;

        if (inputQ != null) inputQ.text = "";
        if (inputA != null) inputA.text = "";

        Debug.Log("Everything is wiped clean!");
    }
}