using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSwitch : MonoBehaviour {

    public GameManager manag;

	// Use this for initialization
	void Start ()
    {
        manag = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {

            
            if (SceneManager.GetActiveScene().name[0] == 'B')
            {
                //Debug.Log("dis som bull shit");
                SceneManager.LoadScene("Hub");
            }

            else if(this.gameObject.transform.position.x < 0)
            {
                manag.brainInc();
                int brain = manag.brainLevel();
                SceneManager.LoadScene("Brain " + brain);
            }

            else if (this.gameObject.transform.position.x > 0)
            {
                manag.brawnInc();
                int brawn = manag.brawnLevel();
                SceneManager.LoadScene("Brawn " + brawn);
            }
        }
    }
}
