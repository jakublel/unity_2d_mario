using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingScript : MonoBehaviour
{
    public float floatingHeight = 0.5f;

    private bool up = true;
    private int count = 0;
    private const int limit = 25;

    public void FixedUpdate()
    {
        Vector3 move = (up) ? new Vector3(0f, floatingHeight / limit, 0f) : new Vector3(0f, -floatingHeight / limit, 0f);
        transform.position += move;
        count++;
        if (count==limit)
        {
            up = !up;
            count = 0;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
