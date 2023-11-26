using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    int score = 0;
    [SerializeField] TextMeshProUGUI Score;

    public void AddScore()
    {
        score++;

        Score.text = score.ToString();
    }
}
