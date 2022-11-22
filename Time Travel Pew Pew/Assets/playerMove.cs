using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    public float Mousesense = 1000f ;
    public Transform playerBody;

    float xRotation = 0f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        playerLooks();
    }




    private void playerMoves()
    {



    }


    private void playerLooks()
    {
        float mouseX = Input.GetAxis("Mouse X") * Mousesense * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Mousesense * Time.deltaTime;


        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);


        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
        
        
      

    }
}
