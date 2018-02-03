using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class aMotion : MonoBehaviour
{

    public float aSpeed = 10;
    public int pauseTime = 50;
    public bool right = true;

    private bool aPause;
    private Vector2 aStart;
    private int pauseCount;
    private int direct;

	// Use this for initialization
	void Start ()
    {
        aStart = this.gameObject.transform.position;
        pauseCount = 0;
        aPause = false;
        if(right)
        {
            direct = 1;
        }
        else
        {
            direct = -1;
        }
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (!aPause)
        {
            this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x + aSpeed * direct / 50f, this.gameObject.transform.position.y);
        }
        else
        {
            pauseCount++;

            if(pauseCount < 0)
            {
                this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x + aSpeed * direct / 50f, this.gameObject.transform.position.y);
            }
            else if (pauseCount > pauseTime)
            {
                this.gameObject.transform.position = aStart;
                aPause = false;
                pauseCount = 0;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Wall")
        {
            pauseCount = pauseCount - 3;
            aPause = true;
        }

        if (col.gameObject.tag == "Key Door")
        {
            pauseCount = pauseCount - 5;
            aPause = true;
        }

        if (col.gameObject.tag == "Switch Door")
        {
            pauseCount = pauseCount - 3;
            aPause = true;
        }

        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}
