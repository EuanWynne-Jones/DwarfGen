using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FamilyData : MonoBehaviour
{
    public DwarfSpawnManager dwarfSpawnManager;
    public List<GameObject> dwarves;

    //public DwarfData dwarfdata;
    public List<string> currentFamilies = new List<string>();


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
         
    }

    public void DwarfFinder()
    {


        currentFamilies.Add(dwarfSpawnManager.dwarf.GetComponent<DwarfData>().familyNameText);
            
        
    }
}
