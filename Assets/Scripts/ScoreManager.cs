using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static float score;
    public TextMeshProUGUI scoreDisplay;
    void Start()
    {
        score = 0;
        scoreDisplay.SetText("Points: " + score);
    }

    public void scoreUpdate()
    {
        score++;
        scoreDisplay.SetText("Points: " + score);
    }
}
