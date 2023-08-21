using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeScripr : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left*Time.deltaTime*speed;
    }
}
