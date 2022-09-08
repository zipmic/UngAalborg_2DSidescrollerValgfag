using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger_DamageHealth : MonoBehaviour
{
    public string TriggerTag = "Player";
	public bool OnlyDamageOnce;
	public int AmountOfDamage = 1;

	private bool _once;
	private bool _isColliding;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (_isColliding) return;
		if (collision.tag == TriggerTag && !_once)
		{
			if (OnlyDamageOnce)
			{
				_once = true;
			}

			collision.GetComponent<Health>().ChangeHealth(AmountOfDamage);
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
