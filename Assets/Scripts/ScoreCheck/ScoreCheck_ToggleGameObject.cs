using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCheck_ToggleGameObject : MonoBehaviour
{
    private ScoreManager _scoreManager;
    private bool _once;
    public int AmountOfPointsToToggle = 1;
    public GameObject GameObjectToToggle;

    void Start()
    {
        _scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        if (_scoreManager == null)
        {
            Debug.LogError("Couln't find reference in start on " + name);
        }

        GetComponent<SpriteRenderer>().enabled = false;
    }

	private void OnDrawGizmos()
	{
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, GameObjectToToggle.transform.position);
	}
	// Update is called once per frame
	void Update()
    {
        if (!_once)
        {
            if (_scoreManager.GetScore() >= AmountOfPointsToToggle)
            {
                _once = true;
                GameObjectToToggle.SetActive(!GameObjectToToggle.activeSelf);
            }
        }
    }
}
