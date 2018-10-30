using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEngine : MonoBehaviour {

    public List<GameObject> AllUnits; // Creates a list to assign all units to
    // Use this for initialization
    void Start()
    {
        AllUnits = new List<GameObject>();
    }

}