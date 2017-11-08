﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    private static int INF = 1000000;
    private Transform transform;
	public Node[] Nodes;
	
    private float weight = INF;
    private int prev = -1;
    private bool isOpen = false;
	
	// Use this for initialization
	void Start () {
        transform = gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public float getWeight()
    {
        return this.weight;
    }
    public void setWeight(float weight)
    {
        this.weight = weight;
    }

    public int getPrev()
    {
        return this.prev;
    }
    public void setPrev(int prev)
    {
        this.prev = prev;
    }
    public bool getIsOpen()
    {
        return this.isOpen;
    }
    public void setIsOpen(bool isOpen)
    {
        this.isOpen = isOpen;
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Player")
        {
            BuildWaySingletone.run(this);
        }
    }
}
