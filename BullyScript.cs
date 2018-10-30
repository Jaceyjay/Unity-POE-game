using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullyScript :MeleeUnit{ //This class inherits from MeleeUit which inherits from Unit allowing access to the variables 

    // Use this for initialization
    void Start () {
        Health = 7;
        Speed = 5;
        Range = 2;
        Damage = 5;
        MoveUnits();
   
    }
	
	// Update is called once per frame
	void Update () {
        MoveUnits();
        //AttackTarget();
	}
}
