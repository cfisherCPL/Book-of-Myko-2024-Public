using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom_Spawner : MonoBehaviour
{
    public GameObject testMush;
    
    public List<GameObject> allPotentialSpawns = new List<GameObject>();

    public List<GameObject> spawnLocations = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        pickSpawns();
        placeMushrooms();
    }



    void pickSpawns()
    {
        
        for (int i = 0; i < 10; i++)
        {
            int rnd = Random.Range(0, allPotentialSpawns.Count);
            GameObject temp = allPotentialSpawns[rnd];
            spawnLocations.Add(temp);
            allPotentialSpawns.RemoveAt(rnd);
        }


    }

    void placeMushrooms()
    {
        for (int i = 0; i < 10; i++)
        {
            Transform placeHere;
            placeHere = spawnLocations[i].GetComponent<Transform>();
            Instantiate(testMush, placeHere); 
        }
    }

}
