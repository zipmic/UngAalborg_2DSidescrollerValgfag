using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger_AddScoreToManager : MonoBehaviour
{

    private ScoreManager _scoreManager;
    private string TriggerTag = "Player";
    public int AmountOfPointsToAdd = 1;
    private bool _once;

    // Start is called before the first frame update
    void Start()
    {
        _scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        if (_scoreManager == null)
        {
            Debug.LogError("Couln't find reference in start on " + name);
        }
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.tag == TriggerTag && !_once )
        {

            if (_scoreManager != null)
            {
                _scoreManager.ChangeScore(AmountOfPointsToAdd);
                _once = true;
            }
            else
            {
                Debug.LogWarning("You need to add the reference on " + name);
            }
        
        }
	}


}
