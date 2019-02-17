using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public bool isBrain = true;
    public int platNum = 0;
    private GameManager manag;

    // Start is called before the first frame update
    void Awake()
    {
        manag = GameObject.Find("GameManager").GetComponent<GameManager>();
        
        if(isBrain == true)
        {
            if(manag.brainLevel() < platNum)
            {
                this.gameObject.SetActive(false);
            }
        }

        if (isBrain == false)
        {
            if (manag.brawnLevel() < platNum)
            {
                this.gameObject.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
