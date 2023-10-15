using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ButtonType1 : MonoBehaviour
{
    [Header("Decorative References")]
    [SerializeField]
    List<GameObject> rimObjects;
    [SerializeField]
    List<GameObject> textObjects;

    [Header("Decorative Colours")]
    [SerializeField]
    Color rimColour;
    [SerializeField]
    Color rimHighColour, textColour, textHighColour;

    [Header("References")]
    [SerializeField]
    Animator animator;

    private void Start()
    {
        foreach(GameObject ii in rimObjects) ii.GetComponent<Image>().color = rimColour;
        foreach (GameObject ii in textObjects) ii.GetComponent<TextMeshProUGUI>().color = textColour;
    }

    public void Press()
    {
        //print(Random.Range(0, 10));
        if(animator != null) animator.SetTrigger("FileClicked");
        StartPersonalAnimation();
    }

    private void StartPersonalAnimation()
    {
        foreach (GameObject ii in rimObjects) ii.GetComponent<Image>().color = rimHighColour;
        foreach (GameObject ii in textObjects) ii.GetComponent<TextMeshProUGUI>().color = textHighColour;
        LeanTween.cancel(gameObject);

        LeanTween.value(gameObject, 0.01f, 1.0f, 0.8f)
            .setEaseInOutSine()
            .setOnUpdate((value) =>
            {
                foreach (GameObject ii in rimObjects) ii.GetComponent<Image>().color = Color.Lerp(rimHighColour, rimColour, value);
                foreach (GameObject ii in textObjects) ii.GetComponent<TextMeshProUGUI>().color = Color.Lerp(textHighColour, textColour, value);
            });
    }
}
