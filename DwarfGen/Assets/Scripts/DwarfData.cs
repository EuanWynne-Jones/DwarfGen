using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DwarfData : MonoBehaviour
{
    // Start is called before the first frame update
 
    public DwarfScriptableObject currentDwarf;
    public ProfessionScriptableObject currentDwarfProfession;
    public string genderText;
    private string FullNameText;
    public string firstNameText;
    public string familyNameText;

    public string professionText;

    public int dwarfAgeText;
    public GameObject dwarfPrefab;


    // Start is called before the first frame update
    void Start()
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



        dwarfAgeText = currentDwarf.dwarfAge = Random.Range(25, 170);

        professionText = currentDwarfProfession.Professions[Random.Range(0, currentDwarfProfession.Professions.Length)];


        dwarfPrefab = currentDwarf.dwarfPrefabs[Random.Range(0, currentDwarf.dwarfPrefabs.Length)];
    }
    private void Update()
    {
        DwarfReport();
        
    }

    public void DwarfReport()
    {
        string FullNameText = firstNameText + " " + familyNameText;
        Debug.Log("Dwarf Report: " + FullNameText + ", " + genderText + ", " + dwarfAgeText + ", " + professionText);
    }

}


