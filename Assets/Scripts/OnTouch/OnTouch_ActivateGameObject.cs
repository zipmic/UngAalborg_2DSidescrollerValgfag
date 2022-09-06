using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouch_ActivateGameObject : MonoBehaviour
{

    public GameObject ActivateThisGameObject;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if (ActivateThisGameObject != null)
            {
                ActivateThisGameObject.SetActive(true);
            }
        }
    }
}
