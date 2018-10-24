using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedUnit : Unit {

	// Use this for initialization
	void Start () {
        Health = 5;
        Speed = 5;
        Range = 7;
        Damage = 3;
        Faction = Random.Range(1, 3);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
