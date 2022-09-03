using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DwarfSpawnManager : MonoBehaviour

{
    public FamilyData family;
    public DwarfScriptableObject currentDwarf;
    public GameObject dwarfPrefab;
    public Transform spawnPosition;
    public GameObject dwarf;
    private GameObject FinishedSpawning;

    public DwarfData dwarfdata;

    public int numberOfDwarvesToSpawn = 10;
    public int spawnedDwarves;
    public bool canSpawn;


    // Start is called before the first frame update
    private void Awake()
    {

        // NPCspawn();
    }
    void Start()
    {
        canSpawn = true;
        spawnedDwarves = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        DwarfSpawn();
    }
    public GameObject DwarfSpawn()
    {
        if(spawnedDwarves < numberOfDwarvesToSpawn)
        {
        canSpawn = true;
            dwarf = Instantiate(dwarfPrefab, spawnPosition.position, spawnPosition.rotation);
            spawnedDwarves++;
            family.dwarves.Add(dwarf);
            family.DwarfFinder();
            return dwarf;
        }
        else
        {
        canSpawn = false;
            return null;
        }

    }


}
