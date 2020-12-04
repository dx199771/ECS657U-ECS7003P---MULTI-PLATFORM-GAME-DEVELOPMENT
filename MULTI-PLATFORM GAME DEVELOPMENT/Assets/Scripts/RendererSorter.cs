using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class RendererSorter : MonoBehaviour
{
    [SerializeField]
    private int sortingOrderBase = 5000;
    [SerializeField]
    private int offset = 0;
    private Renderer myRenderer;

    private void Awake()
    {
        myRenderer = gameObject.GetComponent<Renderer>();
    }

    private void LateUpdate()
    {
        if (transform.position.y < 0)
        {
            myRenderer.sortingOrder = (int)(sortingOrderBase - Math.Sqrt(Math.Pow(transform.position.y, 2.0) + Math.Pow(transform.position.x, 2.0)) * 10 - offset * 10);
        }
        else
        {
            myRenderer.sortingOrder = (int)(sortingOrderBase + Math.Sqrt(Math.Pow(transform.position.y, 2.0) + Math.Pow(transform.position.x, 2.0)) * 10 - offset * 10);
        }
        
    }
}
