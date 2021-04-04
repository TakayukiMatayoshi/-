using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oxpoint : MonoBehaviour
{
    public int pointnum;

    public oxcheak oxcheak;

    public Sprite[] oximage;
    Image button;
    int ox;

    void Start()
    {
        button = gameObject.GetComponent<Image>();
        oxcheak.GetComponent<oxcheak>();

        for(int i=0;i<oximage.Length; i++)
        {
            oximage[i] = oxcheak.oxsprite[i];
        }
    }

    public void oxdown()
    {
        if (button.sprite != oximage[0]) return;

        ox = oxcheak.num;

        button.sprite = oximage[ox];

        oxcheak.numchange(pointnum);
    }
}