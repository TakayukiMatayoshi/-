using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oxcheak : MonoBehaviour
{
    bool oxnum;

    public int num;// 1

    public Sprite[] oxsprite;
    public GameObject[] button;
    public Image[] image;
    public int[] oxnumber;

    public int oxnumX;
    public int oxnumY;

    string Startnumber;

    void Start()
    {
        button = new GameObject[9];

        for (int i = 0; i < oxnumX * oxnumY; i++)
        {
            if (i == 0)
            {
                Startnumber = null;
            } else
            {
                Startnumber = " (" + i + ")";
            }

            button[i] = GameObject.Find("Button" + Startnumber).GetComponent<GameObject>();
            image[i] = GameObject.Find("Button" + Startnumber).GetComponent<Image>();
        }
    }

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
