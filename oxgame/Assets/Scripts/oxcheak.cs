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
    oxpoint[] oxpoints;

    public int oxnumX;
    public int oxnumY;

    string Startnum;

    void Start()
    {
        int bordsize = oxnumX * oxnumY;

        oxnumber = new int[oxnumX, oxnumY];
        button = new GameObject[bordsize];
        image = new Image[bordsize];
        oxpoints = new oxpoint[bordsize];

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
            oxpoints[i] = button[i].GetComponent<oxpoint>();

            oxpoints[i].pointnumX = i % 3;
            oxpoints[i].pointnumY = i / 3;
        }
    }

    public void numchange(int X, int Y)
    {
        oxnumber[X, Y] = num;
        wincheak();

        if (oxnum)
        {
            num = 1;
        } else
        {
            num = 2;
        }

        oxnum = !oxnum;
    }

    void wincheak()
    {
        int count = 0;

        for (int i = 0; i < oxnumX; i++)
        {
            for (int j = 0; j < oxnumY; j++)
            {
                if (oxnumber[i, j] == num)
                {
                    count++;
                } else
                {
                    count = 0;
                }
            }
            if (count == 3)
            {
                Debug.Log("win");
                return;
            }
        }

        for (int i = 0; i < oxnumY; i++)
        {
            for (int j = i; j < oxnumX; j++)
            {
                if (oxnumber[j, i] == num)
                {
                    count++;
                } else
                {
                    count = 0;
                }
            }
            if (count == 3)
            {
                Debug.Log("win");
                return;
            }
        }

        for (int i = 0; i < oxnumY; i++)
        {
            int down = 2;
            for (int j = i; j < oxnumY; j++)
            {
                if (oxnumber[j, down] == num)
                {
                    count++;
                } else
                {
                    count = 0;
                }
                if (count == 3)
                {
                    Debug.Log("win");
                    return;
                }
                down--;
            }
        }

        for (int i = 0; i < oxnumX; i++)
        {
            int up = 0;
            for (int j = 0; j < oxnumY; j++)
            {
                if (oxnumber[j, up] == num)
                {
                    count++;
                } else
                {
                    count = 0;
                }
                if (count == 3)
                {
                    Debug.Log("win");
                    return;
                }
                up++;
            }
        }
    }
}
