using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemovecontroller : MonoBehaviour
{
    //move speed
    float forwardSpeed = 10.0f;
    float zlimit = 27.5f;
    float zlimit2 = -0.9f;
    bool reachz = false;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.z < zlimit && reachz == false)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed);
            
        }
       if ( transform.position.z > zlimit)
        {
            reachz = true;
        }
        if (reachz == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -forwardSpeed);
        }
        if (transform.position.z < zlimit2)
        {
            reachz = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
      {
          if (other.gameObject == Player)
          {
              Player.transform.parent = null;
          }
      }
}
