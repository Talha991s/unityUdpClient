using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Types;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public bool active = false;
    int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if(gameObject.name == FindObjectOfType<NetworkMan>().myAddress){
            active = true;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if (!active)
        {
            return;
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(Vector3.forward);
        }
        else if (Input.GetKey("s"))
        {
            rb.AddForce(Vector3.back);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(Vector3.left);
        }
        else if (Input.GetKey("d"))
        {
            rb.AddForce(Vector3.right);
        }
    }
}
