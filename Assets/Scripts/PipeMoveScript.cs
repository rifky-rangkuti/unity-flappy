using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float movement = 5;
    public float removeZone = -25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + (Vector3.left * movement) * Time.deltaTime;

        if(transform.position.x <= removeZone)
        {
            Destroy(gameObject);
        }
    }
}
