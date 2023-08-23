using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{

    public float moveSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 newPosition = transform.position + Vector3.right * moveSpeed * Time.deltaTime;

            transform.position = newPosition;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 newPosition = transform.position + Vector3.up * moveSpeed * Time.deltaTime;

            transform.position = newPosition;
        }
    }
}
