using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnKeyPress_ResetLevel : MonoBehaviour
{

    public KeyCode ButtonForReset = KeyCode.R;

    void Update()
    {
        if(Input.GetKeyDown(ButtonForReset))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
