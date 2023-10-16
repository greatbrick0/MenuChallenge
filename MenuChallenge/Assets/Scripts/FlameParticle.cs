using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlameParticle : MonoBehaviour
{
    [SerializeField]
    float lifeSpan = 3.0f;
    [SerializeField]
    float age = 0.0f;
    [SerializeField]
    public Vector2 v = Vector2.up * 30;
    [SerializeField]
    Gradient colourGradient;

    void Update()
    {
        age += 1.0f * Time.deltaTime;
        GetComponent<RawImage>().color = colourGradient.Evaluate(age / lifeSpan);
        transform.position += new Vector3(v.x, v.y, 0) * Time.deltaTime;

        if (age > lifeSpan) Destroy(this.gameObject);
    }
}
