using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject brawn;
    public GameObject brain;

    public int brainCount;
    public int brawnCount;
        

	// Use this for initialization
	void Awake ()
    {
        DontDestroyOnLoad(transform.gameObject);
        brainCount = 0;
        brawnCount = 0;
	}

    private void Start()
    {
        brain = GameObject.Find("Brain");
        brawn = GameObject.Find("Brawn");
    }

    // Update is called once per frame
    void Update () {
	
	}

    public void brainInc()
    {
        brainCount++;
    }

    public void brawnInc()
    {
        brawnCount++;
    }

    public int brainLevel()
    {
        return brainCount;
    }

    public int brawnLevel()
    {
        return brawnCount;
    }
}
