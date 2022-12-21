using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="NewPowerupStat",menuName="Powerup/Powerup Stats")]
public class PowerUpStats : ScriptableObject
{
    [SerializeField]
    private float value;

    public float GetValue()
    {
        return value;
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
