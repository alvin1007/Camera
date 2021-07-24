using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody cubeRigidbody;
    float speed = 5f;
    public int jumpCount = 0;

    void Start()
    {
        cubeRigidbody = GetComponent<Rigidbody>();
        transform.position = new Vector3(0, 0.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount == 0)
            {
                jumpCount += 1;
                cubeRigidbody.AddForce(new Vector3(0, 300, 0));
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Plane" && jumpCount == 1)
        {
            jumpCount = 0;
        }
    }
}
