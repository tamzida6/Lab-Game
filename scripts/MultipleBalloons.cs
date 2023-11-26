using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleBalloons : MonoBehaviour
{
    [SerializeField] GameObject balloonPrefab;
    void Start()
    {
        InvokeRepeating("Spawn", 0.0f, .9f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        Instantiate(balloonPrefab, transform.position, transform.rotation);
    }
}
