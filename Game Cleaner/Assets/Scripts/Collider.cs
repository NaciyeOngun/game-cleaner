using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.tag=="wall")
        {
            Destroy(gameObject);
        }
        if (other.tag=="enemy")
        {
            Destroy(other.gameObject);
        }
        if (other.tag=="endGame")
        {
            Destroy(gameObject);
        }
    }
}
