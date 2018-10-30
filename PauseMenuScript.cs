using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour {

    public static bool GamePaused = false;
    public GameObject PauseMenuUI;

    public GameEngine ge;   //used for saving
    public GameObject prefabReference;

    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) // gets key inout
        {
            if(GamePaused) // if game is paused 
            {
                ResumeGame(); //calls resume game function
            }
            else
            {
                PauseGame(); //calls pause game function 
            }
        }
	}
    public void ResumeGame()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }
    public void PauseGame()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void SaveGame()
    {
        // Supposed to be used to save

        //public static void SaveUnits(List<UnitData> units)
        //{
        //    FileStream fs = new FileStream("save.dat", FileMode.Create);
        //    BinaryFormatter bf = new BinaryFormatter();
        //    bf.Serialize(fs, units);
        //    fs.Close();
        //}

        //public void LoadUnits()
        //{
        //    List<UnitData> units;
        //    using (Stream stream = File.Open("save.dat", FileMode.Open))
        //    {
        //        var bformatter = new BinaryFormatter();
        //        units = (List<UnitData>)bformatter.Deserialize(stream);
        //    }

        //    foreach (GameObject removeObject in ge.Units)
        //    {
        //        Destroy(removeObject);
        //    }

        //    ge.Units.Clear();

        //    foreach (GameObject removeObject in ge.Units)
        //    {
        //        GameObject unit = (GameObject)Instantiate(prefabReference);

        //        unit.transform.position = new Vector3(newUnit.x, newUnit.y, 1);
        //        SpriteRenderer sprite = unit.getComponent<SpriteRenderer>();
        //        sprite.sortingLayerName = "Units";
        //        ge.Units.Add(unit);
        //    }

        //    if (ge.Units.Count > 1)
        //    {
        //        foreach (GameObject unit in ge.Units) ;
        //        unit.GetComponent<Unit>().target = ge.Units[geUnits.Count - 1];
        //    }

        //    ge.Units[ge.Units.Count - 1].GetComponents<Unit>().target = GameObject.Find("Main Camera");
        //}
    }
}
