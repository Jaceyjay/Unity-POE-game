using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

    public int faction; //Allows a faction to be set in the inspector of any prefab holding a script that inherits from the Unit class
    public int Health { get; set; }
    public int Speed { get; set; }
    public int Damage { get; set; }
    public int Range { get; set; }
    public string UnitName { get; set; }

    public GameObject ClosestUnit { get; set; }
    public GameEngine GE;

    public void SetGameEngine()
    {
        GE = GameObject.Find("Game Engine").GetComponent<GameEngine>();
    }
    void Awake()
    {
        SetGameEngine(); // sets the game engine as active
    }
    public void MoveUnits()
    {
        
        try
        {
            Debug.Log("Distance " + Vector2.Distance(transform.position, ClosestUnit.transform.position));
            Debug.Log("AttackRange " + Range);
            if (Vector2.Distance(transform.position, ClosestUnit.transform.position) >= Range)
            {

                transform.position = Vector2.MoveTowards(transform.position, ClosestUnit.transform.position, Speed * Time.deltaTime); // Moves the unit towards the closest calulated enemy unit
            }
        }
        catch
        {
            Debug.Log("catch");
            NewTarget();
        }

    }

    public void NewTarget()
    {
        List<GameObject> EnemyUnits; //creates a list called Enemy Units which is assigned the value of the existing list holding all the units AllUnits

        EnemyUnits = GE.AllUnits;

        ClosestUnit = EnemyUnits[0];

        foreach (GameObject newTarget in EnemyUnits) //runs a loop to check every unit if it still exists to assign a new target.
        {
            Unit newUnitTarget = newTarget.GetComponent<Unit>(); //used to reference between 2 units of different teams
            
            if (Vector2.Distance(transform.position, ClosestUnit.transform.position) > Vector2.Distance(transform.position, newTarget.transform.position) && newUnitTarget.faction!= faction)
                ClosestUnit = newTarget;
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    //public void AttackTarget()
    //{
    //    try{ if (ClosestUnit != null)
    //            if (Vector2.Distance(transform.position, ClosestUnit.transform.position) <= Range)
    //                ClosestUnit.GetComponent<Unit>().TakeDamge();
    //    }
    //    catch
    //    {
    //        NewTarget();
    //    }
    //}
           
    
    // void TakeDamge()
    //{
    //    Health--;
    //    if (Health == 0)
    //    {
    //        try
    //        {
    //            Destroy(gameObject);

    //        }
    //        catch
    //        {
    //          //  GE.RemoveDeadUnits();
    //        }
    //    }
    //}
    

    // Update is called once per frame
    void Update()
    {

    }
}

