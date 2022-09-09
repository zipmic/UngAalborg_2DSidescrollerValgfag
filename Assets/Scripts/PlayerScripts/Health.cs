using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
	public int MaxPlayerHealth;
	public int PlayerHealth = 3;
	public UnityEvent EventWhenReceivingDamage;
	public UnityEvent EventWhenReceivingHealth;
	public UnityEvent EventWhenZeroHealth;

	private bool _invincible;
	private bool _isDead;
	private SpriteRenderer _sr;

	private void Start()
	{
		if (PlayerHealth > MaxPlayerHealth)
		{
			PlayerHealth = MaxPlayerHealth;
		}

		_sr = GetComponentInChildren<SpriteRenderer>();
	}

	public void ChangeHealth(int amount)
	{
		if (amount > 0)
		{
			PlayerHealth += amount;
			if (PlayerHealth > MaxPlayerHealth)
			{
				PlayerHealth = MaxPlayerHealth;
			}
			EventWhenReceivingHealth.Invoke();
		}
		else
		{
			if (!_invincible)
			{
				PlayerHealth += amount;

				if (PlayerHealth <= 0 && !_isDead)
				{
					PlayerHealth = 0;
					_isDead = true;
					EventWhenZeroHealth.Invoke();
				}
				else
				{
					StartCoroutine(BlinkEffect());
					EventWhenReceivingDamage.Invoke();

				}

			}
		}
	}

	IEnumerator BlinkEffect()
	{
		_invincible = true;
		for (int i = 0; i < 6; i++)
		{
			_sr.enabled = !_sr.enabled;
			yield return new WaitForSeconds(0.1f);
		}
		_invincible = false;

	}


	public int GetHealth()
	{
		return PlayerHealth;
	}
}
