using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger_ToggleGameObject : MonoBehaviour
{

    public GameObject GameObjectToToggle;
    public string TriggerTag = "Player";
	private bool _once;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == TriggerTag)
		{
			if (GameObjectToToggle != null && !_once)
			{
				GameObjectToToggle.SetActive(!GameObjectToToggle.activeSelf);
				_once = true;
			}
			else if(!_once)
			{
				Debug.LogWarning("You need to add the reference on "+name);
			}
		}
	}

}
