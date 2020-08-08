﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode] // Attribute
[SelectionBase] // An attribute that makes it much harder to grab the top of the cube
[RequireComponent(typeof(Waypoint))]

public class CubeEditor : MonoBehaviour
{

    
    
    
    Waypoint waypoint;

    private void Awake()
    {
        waypoint = GetComponent<Waypoint>();
    }

    void Update()
    {
        SnapToGrid();
        UpdateLabel();
    }

    private void SnapToGrid()
    {
        int gridSize = waypoint.GetGridSize();
        transform.position = new Vector3(
            waypoint.GetGridPos().x,
            0,
            waypoint.GetGridPos().y
            );
    }

    private void UpdateLabel()
    {

        TextMesh textMesh = GetComponentInChildren<TextMesh>();
        int gridSize = waypoint.GetGridSize();

        string labelText =
            waypoint.GetGridPos().x / gridSize +
            "," +
            waypoint.GetGridPos().y / gridSize;
        textMesh.text = labelText;
        gameObject.name = labelText;
    }
}