using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    float speed = 10.0f;
    float maxlimit = 5.0f;
    float gravityModifuer = 2.5f;
    float jumpforce = 13.0f;

    Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifuer;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalinput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");


        //Move Player (Gameobject) according to user interaction
        transform.Translate(Vector3.forward * Time.deltaTime * verticalinput * speed);
      //  transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
        Playerjump();
        
    }
    private void Playerjump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);

        }
    }

   

}
