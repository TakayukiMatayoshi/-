using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oxpoint : MonoBehaviour
{
    bool oxnum = true;
    public GameObject[] oximage;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) oxdown();
    }

    public void oxdown()
    {
        if (oxnum){
            Instantiate(
                oximage[0],
                Vector3.zero,
                Quaternion.identity
                );
        }else{
            Instantiate(
                oximage[1],
                Vector3.zero,
                Quaternion.identity
                );
        }
        oxnum = !oxnum;
    }
}
