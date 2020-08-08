using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    Vector2Int gridPos;
    const int gridSize = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public int GetGridSize()
    {
        return gridSize;
    }

    public Vector2Int GetGridPos()
    {
        return new Vector2Int(
            (int)(Mathf.Round(transform.position.x / gridSize) * gridSize),
            (int)(Mathf.Round(transform.position.z / gridSize) * gridSize)
            );
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
