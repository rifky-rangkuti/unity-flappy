using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    public float jumpStrength;


    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(new Vector3(0, 0, 90));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody2D.velocity = Vector2.up * jumpStrength;
        }
    }
}
