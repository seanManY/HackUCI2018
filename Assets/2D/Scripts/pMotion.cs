 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pMotion : MonoBehaviour
{
    public float pSpeed = 1;
    public float pLength = 5;
    private Vector2 pStart;

	// Use this for initialization
	void Start ()
    {
        pStart = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector2(Mathf.PingPong(Time.time*pSpeed, pLength) + pStart.x, pStart.y);
    }
}
