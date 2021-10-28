using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRB;
    [SerializeField] float speed = 100f;
    private float moveX;
    private float moveZ;
    private Vector3 movement;

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        
    }
    
    // Update is called once per frame
    void Update()
    {

        movement = new Vector3(Input.GetAxisRaw("Horizontal") * speed, 0, Input.GetAxisRaw("Vertical") * speed);
        playerRB.velocity = movement;
       
    }

    private void OnTriggerEnter(Collider other)
    {
        speed = 20f;
    }
}
