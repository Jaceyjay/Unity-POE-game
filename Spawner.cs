using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public int y = 0;
    public int x = 0;
    public int y2 = 0;
    public int x2 = 0;
    List<GameObject> units = new List<GameObject>(); // creates the list of units
    public GameObject prefabReference; // a reference to create the units from prefab
    public GameObject prefabReference2; // a reference to create the units from prefab

    float spawnSpeed = 3f;
	// Use this for initialization
	void Start () {
        InvokeRepeating("GenerateUnit", 0f, spawnSpeed); // will spawn a unit at the start and continously based off the spawn speed
	}
    public List<GameObject> Units //property for units list
    {
        get { return units; }
    }
    public void RemoveUnit(int index) // remove unit from list
    {
        units.RemoveAt(index);
    }
    public int GetIndex(GameObject unit) //Gives the index of a unit
    {
        return units.IndexOf(unit);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void GenerateUnit() //Method to place units
    {
        GameObject unit = (GameObject)Instantiate(prefabReference); // Creates a unit from the selected prefab
        GameObject unit2 = (GameObject)Instantiate(prefabReference2); // Creates a unit from the selected prefab

        unit.transform.position = new Vector3(x, y, 1);
        
        SpriteRenderer sprite = unit.GetComponent<SpriteRenderer>();
        sprite.sortingLayerName = "Unit"; // makes sure the unit spawned is on the correct layer

        unit2.transform.position = new Vector3(x, y, 1);
        SpriteRenderer sprite2 = unit2.GetComponent<SpriteRenderer>();
        sprite2.sortingLayerName = "Unit"; // makes sure the unit spawned is on the correct layer

    }

}
