using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DwarfSpawnManager : MonoBehaviour

{
    //public DwarfScriptableObject[] dwarfFirstName;
    //public DwarfScriptableObject[] dwarfFamilyName;
    public DwarfScriptableObject currentDwarf;
    //public string dwarfFullName;
    public GameObject dwarfPrefab;
    public Transform spawnPosition;
    private GameObject clone;
    // Start is called before the first frame update
    private void Awake()
    {

        // NPCspawn();
    }
    void Start()
    {
        DwarfSpawn();
    }

    // Update is called once per frame
    void Update()
    {

        ;
    }
    public GameObject DwarfSpawn()
    {

        //dwarfFullName = dwarfFirstName[Random.Range(0, dwarfFirstName.Length)];
        clone = Instantiate(dwarfPrefab, spawnPosition.position, spawnPosition.rotation);
        return clone;

    }
}
