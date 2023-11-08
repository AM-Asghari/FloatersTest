using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public Vector3 velocity = new Vector3();
    public float walkingSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0.0f, 0.25f, 0.0f);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0.0f, -0.25f, 0.0f);

        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * Time.deltaTime * walkingSpeed;

        if (Input.GetKey(KeyCode.S))
            transform.position += -transform.forward * Time.deltaTime * walkingSpeed;

    }
}
