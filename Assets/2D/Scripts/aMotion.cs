using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class aMotion : MonoBehaviour
{

    public float aSpeed = 10;
    public int pauseTime = 50;
    public bool right = true;

    private int aPause; //0 = Moving, 1 = Hit Wall, 2 = Hit Door
    private Vector2 aStart;
    private int pauseCount;
    private int direct;

	// Use this for initialization
	void Start ()
    {
        aStart = this.gameObject.transform.position;
        pauseCount = 0;
        aPause = 0;
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
        if (aPause == 0)
        {
            this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x + aSpeed * direct / 50f, this.gameObject.transform.position.y);
        }
        else
        {
            pauseCount++;

            if (aPause == 2 && pauseCount < 0)
            {
                    this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x + aSpeed * direct / 50f, this.gameObject.transform.position.y);
            }

            else if (pauseCount > pauseTime)
            {
                this.gameObject.transform.position = aStart;
                aPause = 0;
                pauseCount = 0;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Wall")
        {
            aPause = 1;
        }

        if (col.gameObject.tag == "Door")
        {
            pauseCount = pauseCount - 5;
            aPause = 2;
        }

            if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}
