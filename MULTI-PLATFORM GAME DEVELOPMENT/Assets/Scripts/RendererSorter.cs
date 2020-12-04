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
        myRenderer.sortingOrder = (int)(sortingOrderBase - (transform.position.y) * 10 - offset * 10);
    }
}
