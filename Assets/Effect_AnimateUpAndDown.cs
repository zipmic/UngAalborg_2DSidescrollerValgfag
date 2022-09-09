using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect_AnimateUpAndDown : MonoBehaviour
{

    public AnimationCurve AnimationCurve;
    public float Speed = 1;
	public float DistanceAdjuster = 1;

    private Vector3 _startPos;
	private float _counter;

	private void Start()
	{
		_startPos = transform.position;
	}

	// Update is called once per frame
	void Update()
    {
		_counter += Time.deltaTime*Speed;
		if (_counter >= 1)
		{
			_counter = 0;
		}
		transform.position = AnimationCurve.Evaluate(Time.timeSinceLevelLoad) * Vector3.up * DistanceAdjuster + _startPos;

	}
}
