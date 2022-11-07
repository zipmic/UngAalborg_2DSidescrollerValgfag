using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerDestroyTag : MonoBehaviour
{

    public string TagToDestroy = "Destroy";

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == TagToDestroy)
		{
			Destroy(collision.gameObject);
		}
	}
}
