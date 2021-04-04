using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oxpoint : MonoBehaviour
{
    bool oxnum = true;

    public Sprite[] oximage;

    public Image button;

    int num;

    public void oxdown()
    {
        if (oxnum)
        {
            num = 0;
        } else {
            num = 1;
        }

        button.sprite = oximage[num];

        oxnum = !oxnum;
    }
}