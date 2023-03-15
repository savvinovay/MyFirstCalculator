using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rasskaz : MonoBehaviour
{
    public SpriteRenderer[] renderers;
    public float speed;
    private float a;
    private int i, l;
    private void Start()
    {
        l = renderers.Length - 1;
        for (int e = 1; e < l + 1; e++) renderers[e].color -= new Color(0, 0, 0, renderers[e].color.a);
    }
    private int getI(int v)
    {
        if (v < l) return v + 1;
        else return 0;
    }
    private void FixedUpdate()
    {
        if (a < 254)
        {
            a += speed;
            renderers[i].color -= new Color(0, 0, 0, speed / 255f);
            renderers[getI(i)].color += new Color(0, 0, 0, speed / 255f);
        }
        else
        {
            if (i < l) i++;
            else i = 0;
            a = 0;
        }
    }
}