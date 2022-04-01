using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 5;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the player forward
        transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical")* speed);
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal")* speed);

        // Get the player to jump
        transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Jump") * jumpForce);
    }
}
