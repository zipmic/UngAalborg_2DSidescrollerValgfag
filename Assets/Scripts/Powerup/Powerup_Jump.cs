using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup_Jump : MonoBehaviour
{

	public float JumpMultiplier = 2;
	public float PowerupTime = 10;
	private bool _once;


	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Player" && !_once)
		{
			collision.GetComponent<Player_PowerupController>().UsePowerup(Player_PowerupController.PowerupType.JumpBoost, JumpMultiplier, PowerupTime);
			_once = true;
		}
	}

}
