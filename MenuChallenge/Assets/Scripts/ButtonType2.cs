using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ButtonType2 : MonoBehaviour
{
    [SerializeField]
    AudioClip soundEffect;

    [SerializeField]
    float animationTime = 0.2f;
    [SerializeField]
    List<NewPos> instantMove;
    [SerializeField]
    List<NewPos> lerpMove;

    [Serializable]
    public class NewPos
    {
        [field: SerializeField]
        public GameObject obj { get; private set; }
        [field: SerializeField]
        public Vector3 pos { get; private set; }
    }

    public void Press()
    {
        if (soundEffect != null) AudioSource.PlayClipAtPoint(soundEffect, new Vector3(0, 0, -10));
        InstantMoves();
        LerpMoves();
    }

    void InstantMoves()
    {
        foreach (NewPos ii in instantMove) ii.obj.transform.localPosition = ii.pos;
    }

    void LerpMoves()
    {
        foreach (NewPos ii in lerpMove)
        {
            LeanTween.cancel(ii.obj);
            LeanTween.moveLocalX(ii.obj, ii.pos.x, animationTime).setEaseOutBack();
            LeanTween.moveLocalY(ii.obj, ii.pos.y, animationTime).setEaseOutBack();
        }
    }
}
