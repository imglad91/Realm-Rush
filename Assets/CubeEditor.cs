using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode] // Attribute
[SelectionBase] // An attribute that makes it much harder to grab the top of the cube
public class CubeEditor : MonoBehaviour
{

    [SerializeField] [Range(1f,20f)] float gridSize = 10f;
    TextMesh textMesh;

    void Update()
    {
        Vector3 snapPos;
        snapPos.x = Mathf.Round(transform.position.x / gridSize) * gridSize;
        snapPos.z = Mathf.Round(transform.position.z / gridSize) * gridSize;

        transform.position = new Vector3(snapPos.x, 0f, snapPos.z);

        textMesh = GetComponentInChildren<TextMesh>();
        string labelText = snapPos.x / 10f + "," + snapPos.z / 10f;
        textMesh.text = labelText;
        gameObject.name = labelText;
    }
}