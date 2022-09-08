using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_Spawn : MonoBehaviour
{

    public GameObject ObjectToSpawn;
    public Transform SpawnPosition;

    public void SpawnObject()
    {
        GameObject tmp = Instantiate(ObjectToSpawn) as GameObject;
        tmp.transform.position = SpawnPosition.position;
    }
}
