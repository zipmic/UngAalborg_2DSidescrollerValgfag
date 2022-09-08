using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class OnCollision_EnableGravity : MonoBehaviour
{

	public string TriggerTag = "Player";
	private bool _once;
	private Rigidbody2D _rb;

	private void Awake()
	{
		_rb = GetComponent<Rigidbody2D>();
		_rb.bodyType = RigidbodyType2D.Static;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == TriggerTag && !_once)
		{
			_once = true;
			_rb.bodyType = RigidbodyType2D.Dynamic;
			GetComponent<Rigidbody2D>().gravityScale = 1;
		}
	}
}
