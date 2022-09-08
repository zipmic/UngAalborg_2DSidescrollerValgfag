using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_DisplayHealth : MonoBehaviour
{

    public Health _playerHealth;
    public Image _heartImage;
    public List<GameObject> ListOfHeart = new List<GameObject>();


    void UpdateAmountOfHearts()
    {
        for (int i = 0; i < ListOfHeart.Count; i++)
        {
            if (i + 1 <= _playerHealth.GetHealth())
            {
                ListOfHeart[i].SetActive(true);
            }
            else
            {
                ListOfHeart[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateAmountOfHearts();
    }
}
