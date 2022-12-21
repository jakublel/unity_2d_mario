using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Immortality", menuName = "Powerup/Immortality")]
public class Immortality : Powerup
{
    [SerializeField]
    private PowerUpStats speedBoost;

    public float GetSpeedBoost() { return speedBoost.GetValue(); }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
