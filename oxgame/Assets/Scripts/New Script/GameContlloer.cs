using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContlloer : MonoBehaviour
{
    int[,] bord;
    public int bordsizeX;
    public int bordsizeY;

    public const int enpty = 0;
    public const int o = 1;
    public const int x = -1;

    public int collentplay = o;

    Camera camera_object;
    RaycastHit hit;

    public Sprite o_sprite;
    public Sprite x_sprite;

    void Start()
    {
        camera_object = GameObject.Find("MainCamera").GetComponent<Camera>();

        bord = new int[bordsizeX, bordsizeY];

        ResetBord();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) oxdown();
    }

    void oxdown()
    {
        Ray ray = camera_object.ScreenPointToRay(Input.mousePosition);
    }

    void ResetBord()
    {
        for (int i = 0; i < bordsizeX; i++)
        {
            for (int n=0;n < bordsizeY; n++)
            {
                bord[i, n] = enpty;
            }
        }
    }
}