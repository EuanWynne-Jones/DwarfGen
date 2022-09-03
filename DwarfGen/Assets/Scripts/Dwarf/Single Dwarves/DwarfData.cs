using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DwarfData : MonoBehaviour
{
    // Start is called before the first frame update

    public DwarfScriptableObject currentDwarf;
    public FirstName currentDwarfMaleFirstName;
    public FirstName currentDwarfFemaleFirstName;
    public LastName currentDwarfFamilyName;
    public ProfessionScriptableObject currentDwarfProfession;
    public ProfessionData professions;

    public ProfessionScriptableObject child;

    public string genderText;
    public string firstNameText;
    public string familyNameText;



    public int dwarfAgeText;
    public GameObject dwarfPrefab;

    private void Awake()
    {
        //currentDwarf = null;
        //professions = null;
        //currentDwarfProfession = null;
        DwarfGenerator();
    }

    // Start is called before the first frame update
    void Start()
    {
    
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
            firstNameText = currentDwarfMaleFirstName.prefix[Random.Range(0, currentDwarfMaleFirstName.prefix.Count)] + currentDwarfMaleFirstName.suffix[Random.Range(0, currentDwarfMaleFirstName.suffix.Count)];
        }
            else if( genderText == "Female")
            {
            firstNameText = currentDwarfFemaleFirstName.prefix[Random.Range(0, currentDwarfFemaleFirstName.prefix.Count)] + currentDwarfFemaleFirstName.suffix[Random.Range(0, currentDwarfFemaleFirstName.suffix.Count)];
            }
        familyNameText = currentDwarfFamilyName.prefix[Random.Range(0, currentDwarfFamilyName.prefix.Count)] + currentDwarfFamilyName.suffix[Random.Range(0, currentDwarfFamilyName.suffix.Count)];

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


