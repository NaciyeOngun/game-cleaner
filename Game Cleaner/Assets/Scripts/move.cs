using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float moved;
    [SerializeField] float jump;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -speed * Time.deltaTime);
       /* if (Input.GetKey(KeyCode.A))
        {
            transform.Translate( moved * Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-moved * Time.deltaTime, 0, 0);
        }*/
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(moved * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(-moved * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            //transform.Translate(0,jump , 0);
            // rb.AddForce(new Vector3(0,jump, 0),ForceMode.Impulse);
            //rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            rb.velocity = Vector3.up * jump;

        }
    }
}
