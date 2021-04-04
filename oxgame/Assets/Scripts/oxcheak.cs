using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oxcheak : MonoBehaviour
{
    bool oxnum = true;

    public int num;

    private void Start()
    {
        numchange();
    }

    public void numchange()
    {
        if (oxnum)
        {
            num = 0;
        }
        else
        {
            num = 1;
        }

        oxnum = !oxnum;
    }
}
