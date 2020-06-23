using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{

    const float Gravity = 9.8f;

    public float gravityScale = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = new Vector3();

        if (Application.isEditor) {
            vector.x = Input.GetAxis("Horizontal");
            vector.z = Input.GetAxis("Vertical");

            if (Input.GetKey("z")) {
                vector.y = 1.0f;
            } else {
                vector.y = -1.0f;
            }
        } else {
            vector = Input.acceleration;
        }

        Physics.gravity = Gravity * vector.normalized * gravityScale;
    }
}
