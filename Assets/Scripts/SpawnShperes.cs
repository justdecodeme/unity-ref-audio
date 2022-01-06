using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShperes : MonoBehaviour
{
    public GameObject prefab;

    public void Spawn()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-4, 4), Random.Range(4, 6), Random.Range(-4, 4));
        Instantiate(prefab, spawnPos, Quaternion.identity);
    }
}
