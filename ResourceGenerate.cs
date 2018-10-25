using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResourceGenerate : MonoBehaviour {
    public int counter;
    public Text ResourceText;
    public int Resources;
    public int team;

    // Use this for initialization
    void Start () {
       
        Resources = Resources + Random.Range(0, 6);
        InvokeRepeating("IncreaseResources", 0f, 3.0f);
    }
	
	// Update is called once per frame
	void Update () {

       
            
	}

    void IncreaseResources()
    {
        counter++;
        Resources = Resources + Random.Range(0, 6);
        Resources.ToString();
        counter = 0;
        ResourceText.text = "Team " + team.ToString() + " Resources: " + Resources;
    }
    public void DeductResources()
    {

    }
}
