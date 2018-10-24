using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeUnit : Unit {


    // Use this for initialization

    void Start () {
        Health = 10;
        Speed = 5;
        Range = 2;
        Damage = 4;
        Faction = Random.Range(1, 3);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
