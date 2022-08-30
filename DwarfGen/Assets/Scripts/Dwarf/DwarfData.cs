using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DwarfData : MonoBehaviour
{
    // Start is called before the first frame update
 
    public DwarfScriptableObject currentDwarf;
    public ProfessionScriptableObject currentDwarfProfession;
    public ProfessionData professions;

    public ProfessionScriptableObject child;

    public string genderText;
    public string firstNameText;
    public string familyNameText;



    public int dwarfAgeText;
    public GameObject dwarfPrefab;
 

    // Start is called before the first frame update
    void Start()
    {
        DwarfGenerator();
    }
    private void Update()
    {
        
        
    }

    public void DwarfReport()
    {
        string FullNameText = firstNameText + " " + familyNameText;
        string professionText = currentDwarfProfession.name;
        print("Dwarf Report: " + FullNameText + ", " + genderText + ", " + dwarfAgeText + ", " + professionText);
    }

    public void DwarfGenerator()
    {
        genderText = currentDwarf.Gender[Random.Range(0, currentDwarf.Gender.Length)];
        if (genderText == "Male")
        {
            firstNameText = currentDwarf.MaleFirstNameList[Random.Range(0, currentDwarf.MaleFirstNameList.Length)];
        }
            else if( genderText == "Female")
            {
                firstNameText = currentDwarf.FemaleFirstNameList[Random.Range(0, currentDwarf.FemaleFirstNameList.Length)];
            }
        familyNameText = currentDwarf.familyNameList[Random.Range(0, currentDwarf.familyNameList.Length)];

        dwarfAgeText = currentDwarf.dwarfAge = Random.Range(21 , 175);

        currentDwarfProfession = professions.allProfessions[Random.Range(0, professions.allProfessions.Count)];
        /*
        if (dwarfAgeText >20)
        {
        currentDwarfProfession = professions.allProfessions[Random.Range(0, professions.allProfessions.Count)];
        }
        else
        {
            currentDwarfProfession = child;
        }
        */


        dwarfPrefab = currentDwarf.dwarfPrefabs[Random.Range(0, currentDwarf.dwarfPrefabs.Length)];
        dwarfPrefab.name = firstNameText + " " + familyNameText;
       
    }


}


