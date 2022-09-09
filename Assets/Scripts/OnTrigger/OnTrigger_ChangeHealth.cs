using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger_ChangeHealth : MonoBehaviour
{
    public string TriggerTag = "Player";
	public bool OnlyApplyOnce;
	public int AmountOfChange = 1;

	private bool _once;
	private bool _isColliding;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (_isColliding) return;
		if (collision.tag == TriggerTag && !_once)
		{
			if (OnlyApplyOnce)
			{
				_once = true;
			}

			collision.GetComponent<Health>().ChangeHealth(AmountOfChange);
			_isColliding = true;
			StartCoroutine(Reset());
	}
	}

	IEnumerator Reset()
	{
		yield return new WaitForSeconds(0.5f);
		//yield return new WaitForEndOfFrame();
		_isColliding = false;
	}
}
