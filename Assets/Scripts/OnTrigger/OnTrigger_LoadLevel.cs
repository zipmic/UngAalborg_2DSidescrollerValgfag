using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTrigger_LoadLevel : MonoBehaviour
{

    public string LevelToLoad;
    public float WaitTimeBeforeLoad = 1;
    public string TriggerTag = "Player";

    private bool once;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == TriggerTag)
        {
            if (!once)
            {
                StartCoroutine(WaitAndGo());
                once = true;
            }
        }
    }

    IEnumerator WaitAndGo()
    {
        yield return new WaitForSeconds(WaitTimeBeforeLoad);
        SceneManager.LoadScene(LevelToLoad);
    }
}
