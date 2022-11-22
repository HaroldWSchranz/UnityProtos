using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;

    [SerializeField] int platformCount = 300;
    [SerializeField] float platformXmin = -1.25f;
    [SerializeField] float platformXmax = 1.25f;
    [SerializeField] float platformYstart = 0f;
    [SerializeField] float platformYminSpace = 0.5f;
    [SerializeField] float platformYmaxSpace = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        spawnPosition.y = platformYstart;

        for (int i = 0; i < platformCount; i++)
        {
            spawnPosition.y += Random.Range(platformYminSpace,platformYmaxSpace);
            spawnPosition.x = Random.Range(platformXmin,platformXmax);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
