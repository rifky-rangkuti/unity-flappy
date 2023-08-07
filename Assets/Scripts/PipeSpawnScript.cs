using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2.0f;
    public float time = 0;
    public float maxDistance = 4.79f;
    // Start is called before the first frame update
    void Start()
    {
            spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("DELTATIME: " + Time.deltaTime);
        if(time < spawnRate)
        {
            time += Time.deltaTime;
        }
        else
        {
            time = 0;
            spawnPipe();
        }
    }

    void spawnPipe()
    {
        float lowest = transform.position.y - maxDistance;
        float highest = transform.position.y + maxDistance;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowest, highest), 0), transform.rotation);
    }
}
