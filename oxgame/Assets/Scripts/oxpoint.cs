using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oxpoint : MonoBehaviour
{
    public oxcheak oxcheak;

    public Sprite[] oximage;

    public Image button;

    int ox;

    void Start()
    {
        oxcheak.GetComponent<oxcheak>();
    }

    public void oxdown()
    {
        ox = oxcheak.num;

        button.sprite = oximage[ox];

        oxcheak.numchange();
    }
}