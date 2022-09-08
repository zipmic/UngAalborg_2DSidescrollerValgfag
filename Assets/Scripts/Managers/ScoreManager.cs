using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    private int PlayerScore = 0;
    public string TextBeforeScore, TextAfterScore;
    public TextMeshProUGUI UITextToDisplayScore;

	private void Start()
	{
        RefreshScoreText();
	}

	public void ChangeScore(int amount)
    {
        PlayerScore += amount;
        RefreshScoreText();
    }

    void RefreshScoreText()
    {
        if (UITextToDisplayScore != null)
        {
            UITextToDisplayScore.text = TextBeforeScore + PlayerScore + TextAfterScore;
        }
    }

    public int GetScore()
    {
        return PlayerScore;
    }
}
