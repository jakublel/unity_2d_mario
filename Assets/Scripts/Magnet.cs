using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Magnet", menuName = "Powerup/Magnet")]
public class Magnet : Powerup
{
    [SerializeField]
    private PowerUpStats speed;
    public float GetSpeed() { return speed.GetValue(); }

    [SerializeField]
    private PowerUpStats range;
    public float GetRange() { return range.GetValue(); }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
