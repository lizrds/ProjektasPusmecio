using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Water : MonoBehaviour
{
    public GameObject target;
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rise();
    }

    private void Rise()
    {
        Vector3 newPosition = Vector3.Lerp(transform.position, target.transform.position, speed * Time.deltaTime);
        transform.position = newPosition;

    }
}
