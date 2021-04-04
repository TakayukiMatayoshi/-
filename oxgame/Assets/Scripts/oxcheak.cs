using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oxcheak : MonoBehaviour
{
    bool oxnum;

    public int num;// 1

    public Sprite[] oxsprite;
    public Image[] image;
    public int[] oxnumber;

    public void numchange(int n)
    {
        if (oxnum)
        {
            num = 1;
        }
        else
        {
            num = 2;
        }

        oxnumber[n] = num;
        oxnum = !oxnum;
    }
}
