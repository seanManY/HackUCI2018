using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dMotion : MonoBehaviour
{
    private Vector2 locat;
    private bool open;

	// Use this for initialization
	void Start ()
    {
        open = false;
        locat = this.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!open && this.gameObject.transform.position.y > locat.y)
        {
            this.gameObject.transform.position = new Vector2(locat.x, this.gameObject.transform.position.y - .04f);
        }

        if (open && this.gameObject.transform.position.y < locat.y + 4f)
        {
            this.gameObject.transform.position = new Vector2(locat.x, this.gameObject.transform.position.y + .04f);
        }
    }

    public void openDoor()
    {
        open = true;
    }

    public void closeDoor()
    {
        open = false;
    }
}
