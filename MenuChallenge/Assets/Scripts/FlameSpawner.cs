using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameSpawner : MonoBehaviour
{
    [SerializeField]
    float timeSinceFlame = 0.0f;
    [SerializeField]
    float timeBetweenFlames = 0.2f;

    [SerializeField]
    GameObject flameObj;
    GameObject flameRef;

    void Update()
    {
        timeSinceFlame += 1.0f * Time.deltaTime;
        if(timeSinceFlame > timeBetweenFlames)
        {
            SpawnFlame();
            timeSinceFlame = 0.0f;
        }
    }

    void SpawnFlame()
    {
        flameRef = Instantiate(flameObj, transform);
        flameRef.transform.position = transform.position;
        flameRef.GetComponent<FlameParticle>().v.x = Random.Range(-10, 10);
    }
}
