using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool fallIn;

    public bool IsFallIn()
    {
        return fallIn;
    }

    public string activeTag;

    void OnTriggerStay(Collider other)
    {
        Rigidbody r = other.gameObject.GetComponent<Rigidbody>();

        Vector3 direction = transform.position - other.gameObject.transform.position;
        direction.Normalize();

        if (other.gameObject.tag == activeTag)
        {
            r.velocity *= 0.9f;
            r.AddForce(direction * r.mass * 20f);
        } else
        {
            r.AddForce(-direction * r.mass * 80f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == activeTag)
        {
            fallIn = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == activeTag)
        {
            fallIn = false;
        }
    }
}
