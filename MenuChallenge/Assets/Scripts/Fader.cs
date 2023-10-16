using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fader : MonoBehaviour
{
    [SerializeField]
    Image fadePanel;

    public void FadeIn()
    {
        fadePanel.color = new Color(0, 0, 0, 1);

        LeanTween.value(gameObject, 0.01f, 1.0f, 0.8f).setEaseInOutSine().setOnUpdate((value) =>
        {
            fadePanel.color = new Color(0, 0, 0, 1 - value);
        });
    }
}
