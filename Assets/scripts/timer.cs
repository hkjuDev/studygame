using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timertext;
    float remainingTime;

    private int maxtime = 1800;
    public GameObject studyScreen;
    public GameObject testScreen;

    void Start()
    {
        int qr = questionstorage.wrongAnswersCount;
        int total = questionstorage.totalQuestionsCount;

        if (total <= 0)
        {
            remainingTime = 0;
        }
        else
        {
            float prc_incorect = (float)qr / (float)total;
            remainingTime = prc_incorect * maxtime;
        }
    }

    void Update()
    {
        if (remainingTime <= 0)
        {
            remainingTime = 0;
            timertext.text = "TEST READY";
            timertext.color = Color.green;
        }
        else
        {
            remainingTime -= Time.deltaTime;

            int minuts = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);
            timertext.text = string.Format("{0:00}:{1:00}", minuts, seconds);
            timertext.color = Color.white;
        }
    }

    public void TryGoToNextFrame()
    {
        if (remainingTime <= 0)
        {
            Debug.Log("Success! Heading to Test.");
            SceneManager.LoadScene(2);
        }
        else
        {
            Debug.Log("Wait! Timer is still running.");
        }
    }
}