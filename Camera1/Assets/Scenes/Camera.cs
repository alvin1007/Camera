using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform Cube;
    private float rotateSpeed = 30f;
    private float angle1 = 0, angle2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(10 * Mathf.Cos(angle1 * Mathf.PI / 180.0f) * Mathf.Cos(angle2* Mathf.PI / 180.0f), 10 * Mathf.Sin(angle2* Mathf.PI / 180.0f), 10 * Mathf.Sin(angle1 * Mathf.PI / 180.0f) * Mathf.Cos(angle2 * Mathf.PI / 180.0f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            angle1 = angle1 + rotateSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            angle1 = angle1 - rotateSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            angle2 = angle2 + rotateSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            angle2 = angle2 - rotateSpeed * Time.deltaTime;
        }
        transform.LookAt(Cube);
        Move();
    }

    void Move()
    {
        transform.position = new Vector3(10 * Mathf.Cos(angle1 * Mathf.PI / 180.0f) * Mathf.Cos(angle2 * Mathf.PI / 180.0f), 10 * Mathf.Sin(angle2 * Mathf.PI / 180.0f),10 * Mathf.Sin(angle1 * Mathf.PI / 180.0f) * Mathf.Cos(angle2 * Mathf.PI / 180.0f));
    }
}
