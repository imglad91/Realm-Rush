using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class EditorSnap : MonoBehaviour
{ 

    void Update()
    {
        Vector3 snapPos;
        snapPos.x = Mathf.Round(transform.position.x / 10f) * 10f;
        snapPos.z = Mathf.Round(transform.position.z / 10f) * 10f;

        transform.position = new Vector3(snapPos.x, 0f, snapPos.z);
        

        
    }
}