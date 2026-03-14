using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void GoToAddQuestions()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToTest()
    {
        // Only let them test if they actually added questions!
        if (questionstorage.masterDeck.Count > 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}