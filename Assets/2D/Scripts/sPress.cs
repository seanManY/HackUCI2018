using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sPress : MonoBehaviour
{
    private Vector2 locat;
    private bool pressed;

    public dMotion door;

	// Use this for initialization
	void Start ()
    {
        pressed = false;
        locat = this.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!pressed && this.gameObject.transform.position.y < locat.y)
        {
            this.gameObject.transform.position = new Vector2(locat.x, this.gameObject.transform.position.y + .02f);
        }

        if (pressed && this.gameObject.transform.position.y > locat.y - .3f)
        {
            this.gameObject.transform.position = new Vector2(locat.x, this.gameObject.transform.position.y - .02f);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Crate")
        {
            pressed = true;
            door.openDoor();
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Crate")
        {
            pressed = false;
            door.closeDoor();
        }
    }
}
