using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float moved;
   

    // Start is called before the first frame update
    void Start()
    {
        
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
        
    }
}
