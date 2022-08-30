using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public enum FirstName
{
    Nunruk,
    Kamlam,
    Gisor,
    Brilrin,
    Mirlin,
    Dubi,
    Doin,
    Kugo,
    Lun,
    Gale
}


 public enum FamilyName
{
     Beastbane,
     Marbleflayer,
     Trollbraids,
     Redarmour,
     Pebblefall,
     Kegforge,
     Wraithview,
     Magmagrip,
     Chaosborn,
     Granitemail
}


[CreateAssetMenu(fileName = "Dwarf Data", menuName = "ScriptableObjects/Dwarf", order = 1)]
public class DwarfScriptableObject : ScriptableObject
{
    //public string DwarfName;
    public string[] Gender;
    public string[] MaleFirstNameList;
    public string[] FemaleFirstNameList;

    public string[] familyNameList;
    public int dwarfAge;





    public GameObject[] dwarfPrefabs;

}

