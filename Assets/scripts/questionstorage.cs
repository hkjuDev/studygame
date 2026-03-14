using System.Collections.Generic;
using UnityEngine;

public class questionstorage : MonoBehaviour
{
    [System.Serializable]
    public class StudyPair
    {
        public string question;
        public string answer;
    }

    public static List<StudyPair> masterDeck = new List<StudyPair>();

    // Stats tracking
    public static int totalQuestionsCount = 0;
    public static int wrongAnswersCount = 0;
}