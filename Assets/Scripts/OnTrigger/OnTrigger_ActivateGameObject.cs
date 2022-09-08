using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger_ActivateGameObject : MonoBehaviour
{

    public GameObject ActivateThisGameObject;
    public string TriggerTag = "Player";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if (ActivateThisGameObject != null)
            {
                ActivateThisGameObject.SetActive(true);
            }
            else
            {
                Debug.LogWarning("You need to add the reference on " + name);
            }
        }
    }
}
