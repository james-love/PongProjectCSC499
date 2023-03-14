using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI leftText;
    [SerializeField] private TextMeshProUGUI rightText;
    private int leftScore = 0;
    private int rightScore = 0;

    public void LeftScore()
    {
        leftScore++;
        UpdateDisplay();
    }

    public void RightScore()
    {
        rightScore++;
        UpdateDisplay();
    }

    private void Start()
    {
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        leftText.text = leftScore.ToString();
        rightText.text = rightScore.ToString();
    }
}
