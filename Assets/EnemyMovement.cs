﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] List<Waypoint> path;
    // Start is called before the first frame update
    void Start()
    {

        
        
    }

    IEnumerator FollowPath()
    {
        print("Starting patrol");
        foreach (Waypoint waypoint in path)
        {
            transform.position = waypoint.transform.position;
            print("Visiting block:" + waypoint.name);
            yield return new WaitForSeconds(1f);
        }
        print("Ending patrol");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
    