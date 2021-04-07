using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oxcheak : MonoBehaviour
{
    bool oxnum;

    public int num;// 1

    public Sprite[] oxsprite;
    public int[,] oxnumber;
    GameObject[] button;
    Image[] image;

    public int oxnumX;
    public int oxnumY;

    string Startnum;

    void Start()
    {
        int bordsize = oxnumX * oxnumY;

        oxnumber = new int[oxnumX, oxnumY];
        button = new GameObject[bordsize];
        image = new Image[bordsize];

        for (int i = 0; i < bordsize; i++)
        {
            if (i == 0)
            {
                Startnum = null;
            } else
            {
                Startnum = " (" + i + ")";
            }

            button[i] = GameObject.Find("Button" + Startnum);
            image[i] = button[i].GetComponent<Image>();
        }
    }

    public void numchange(int X, int Y)
    {
        if (oxnum)
        {
            num = 1;
        } else
        {
            num = 2;
        }
        oxnumber[X, Y] = num;
        oxnum = !oxnum;

        for (int j = 0; j < oxnumX; j++)
        {
            for (int k = 0; k < oxnumY; k++)
            {
                Debug.Log("[" + j + "," + k + "]=" + oxnumber[j, k]);
            }
        }
    }
}
