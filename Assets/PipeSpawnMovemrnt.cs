using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnMovemrnt : MonoBehaviour
{
    public GameObject spawnPipe;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 1, 3);

    }

    // Update is called once per frame
    void Update()
    {
    }
    void spawn()
    {
        float RandomSpawnPipe = Random.Range(1.5f, -2.94f);
        Instantiate(spawnPipe, new Vector3(4,RandomSpawnPipe,0), Quaternion.identity);

    }
}
