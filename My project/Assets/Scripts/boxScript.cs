using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    private int count;

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        count = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            count++
            if(count = 3)
            {
                this.gameObject.SendMessage();
            }
            print("box collision enter" + count);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
