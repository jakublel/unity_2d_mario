using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : ScriptableObject
{
    public bool isActive;

    [SerializeField]
    protected PowerUpStats duration;

    public float GetDuration() { return duration.GetValue(); }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
