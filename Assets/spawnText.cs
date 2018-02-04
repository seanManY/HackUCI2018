using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnText : MonoBehaviour {

    public GameObject text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            text.transform.position = new Vector2(-325.81f, -125.6f);
        }
    }
}
