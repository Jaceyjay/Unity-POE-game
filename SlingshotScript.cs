using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingshotScript : RangedUnit {

	// Use this for initialization
	void Start () {
        Health = 5;
        Speed = 7;
        Range = 7;
        Damage = 3;
        MoveUnits();
    }
	
	// Update is called once per frame
	void Update () {
        MoveUnits();
        //AttackTarget();
    }
}
