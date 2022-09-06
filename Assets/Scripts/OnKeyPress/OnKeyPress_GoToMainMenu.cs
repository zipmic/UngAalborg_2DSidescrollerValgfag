using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnKeyPress_GoToMainMenu : MonoBehaviour
{

    public KeyCode ButtonToLoadMenu = KeyCode.Escape;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
