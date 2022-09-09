using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTrigger_Event : MonoBehaviour
{
    public string TriggerTag = "Player";
    public UnityEvent EventToTrigger;
    public bool OnlyTriggerOnce;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == TriggerTag)
        {
            EventToTrigger.Invoke();
        }
    }
}
