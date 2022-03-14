using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    private float horizontal;
    private float vertical;
    //private float offset = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal" );
        vertical = Input.GetAxis("Vertical" );
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical );
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontal  );
    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
