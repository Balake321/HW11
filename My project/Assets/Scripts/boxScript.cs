using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity

public class boxScript : MonoBehaviour
{
    private int count;
    public GameObject thePlayer;

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        count = 0;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            CORE.display()
            count++
            if(count == 3)
            {
                this.gameObject.SendMessage("DoSomething");
                Destory(this.gameObject);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        playerPosition = thePlayer.transform.position;
        rb.velocity = new Vector3(playerPosition.x * speed, playerPosition.y * speed, playerposition.z * speed);
    }
}
