using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_PowerupController : MonoBehaviour
{

    public enum PowerupType { SpeedBoost, JumpBoost };

    private PlayerMovement _playerMovement;
    private CharacterController2D _charController;
    private float _startSpeed, _startJump;

	private void Start()
	{

        _playerMovement = GetComponent<PlayerMovement>();
        _charController = GetComponent<CharacterController2D>();

        _startSpeed = _playerMovement.runSpeed;
        _startJump = _charController.m_JumpForce;

    }


	public void UsePowerup(PowerupType Power, float Multiplier, float Duration)
    {
        if (Power == PowerupType.SpeedBoost)
        {
            StartCoroutine(SpeedBoost(Multiplier,Duration));
        }
        if (Power == PowerupType.JumpBoost)
        {
            StartCoroutine(JumpBoost(Multiplier,Duration));
        }

    }

    IEnumerator SpeedBoost(float multiplier, float duration)
    {
        _playerMovement.runSpeed = _startSpeed * multiplier;
        yield return new WaitForSeconds(duration);
        _playerMovement.runSpeed = _startSpeed;
    }

    IEnumerator JumpBoost(float multiplier, float duration)
    {
        _charController.m_JumpForce = _startJump * multiplier;
        yield return new WaitForSeconds(duration);
        _charController.m_JumpForce = _startJump;
    }
}
