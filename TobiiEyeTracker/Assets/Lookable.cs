using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;

public class Lookable : MonoBehaviour
{
    public bool lookedAt = false;
    GazeAware gazeAware;
    public Renderer myRenderer;

    // Use this for initialization
    void Start()
    {
        gazeAware = GetComponent<GazeAware>();
        myRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gazeAware.HasGazeFocus)
        {
            lookedAt = true;
            myRenderer.material.color = Color.red;
        }
    }
}