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
    Color rimHighColour;
    [SerializeField]
    Color textColour;
    [SerializeField]
    Color textHighColour;

    [Header("References")]
    [SerializeField]
    Animator animator;

    private void Start()
    {
        foreach(GameObject ii in rimObjects)
        {
            ii.GetComponent<Image>().color = rimColour;
        }
        foreach (GameObject ii in textObjects)
        {
            ii.GetComponent<TextMeshProUGUI>().color = textColour;
        }
    }

    public void Press()
    {
        //print(Random.Range(0, 10));
        if(animator != null) animator.SetTrigger("FileClicked");
    }
}
