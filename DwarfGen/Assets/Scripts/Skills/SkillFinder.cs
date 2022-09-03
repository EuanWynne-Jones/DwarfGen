using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillFinder : MonoBehaviour
{
    public DwarfData currentDwarfInfo;

    public ProfessionScriptableObject curretProfession;

    public List<string> currentDwarfSkills = new List<string>();
    public List<Skill> allSkills = new List<Skill>();
    //public List<SkillFinder> currentDwarfSkills = new List<SkillFinder>();
    // Start is called before the first frame update
    void Start()
    {
        Skillchecker();
    }
    public void Skillchecker()
    {
        curretProfession = currentDwarfInfo.currentDwarfProfession;


        if (curretProfession.mining)
        {
            allSkills.Add(new Skill("Mining", true));
        }
        else
        {
            allSkills.Add(new Skill("Mining", false));

        }


        if (curretProfession.masonry)
        {
            allSkills.Add(new Skill("Masonry", true));
        }
        else
        {
            allSkills.Add(new Skill("Masonry", false));
        }


        if (curretProfession.stoneDetailing)
        {
            allSkills.Add(new Skill("Stone Detailing", true));
        }
        else
        {
            allSkills.Add(new Skill("Stone Detailing", false));
        }



        if (curretProfession.carpentry)
        {
            allSkills.Add(new Skill("Carpentry", true));
        }
        else
        {
            allSkills.Add(new Skill("Carpentry", false));
        }


        if (curretProfession.woodCutting)
        {
            allSkills.Add(new Skill("Wood Cutting", true));
        }
        else
        {
            allSkills.Add(new Skill("Wood Cutting", false));
        }


        if (curretProfession.plantGathering)
        {
            allSkills.Add(new Skill("Plant Gathering", true));
        }
        else
        {
            allSkills.Add(new Skill("Plant Gathering", false));

        }


        if (curretProfession.plantProcessing)
        {
            allSkills.Add(new Skill("Plant Processing", true));
        }
        else
        {
            allSkills.Add(new Skill("Plant Processing", false));
        }


        if (curretProfession.carpentry)
        {
            allSkills.Add(new Skill("Field Farming", true));
        }
        else
        {
            allSkills.Add(new Skill("Field Farming", false));
        }


        if (curretProfession.fieldFarming)
        {
            allSkills.Add(new Skill("Field Farming", true));
        }
        else
        {
            allSkills.Add(new Skill("Field Farming", false));

        }

        if (curretProfession.beekeeping)
        {

            allSkills.Add(new Skill("Beekeeping", true));
        }
        else
        {
            allSkills.Add(new Skill("Beekeeping", false));
        }


        if (curretProfession.spinning)
        {
            allSkills.Add(new Skill("Spinning", true));
        }
        else
        {
            allSkills.Add(new Skill("Spinning", false));
        }


        if (curretProfession.cooking)
        {
            allSkills.Add(new Skill("Cooking", true));
        }
        else
        {
            allSkills.Add(new Skill("Cooking", false));
        }


        if (curretProfession.animalCare)
        {
            allSkills.Add(new Skill("AnimalCare", true));
        }
        else
        {
            allSkills.Add(new Skill("AnimalCare", false));
        }


        if (curretProfession.animalTraining)
        {
            allSkills.Add(new Skill("Animal Training", true));
        }
        else
        {
            allSkills.Add(new Skill("Animal Training", false));
        }


        if (curretProfession.trapping)
        {
            allSkills.Add(new Skill("Trapping", true));
        }
        else
        {
            allSkills.Add(new Skill("Trapping", false));
        }


        if (curretProfession.butchery)
        {
            allSkills.Add(new Skill("Butchery", true));
        }
        else
        {
            allSkills.Add(new Skill("Butchery", false));
        }


        if (curretProfession.fishing)
        {
            allSkills.Add(new Skill("Fishing", true));
        }
        else
        {

            allSkills.Add(new Skill("Fishing", false));
        }

        if (curretProfession.fishCleaning)
        {
            allSkills.Add(new Skill("Fishing Cleaning", true));
        }
        else
        {

            allSkills.Add(new Skill("Fishing Cleaning", false));
        }

        if (curretProfession.fishDisection)
        {
            allSkills.Add(new Skill("Fish Disection", true));
        }
        else
        {
            allSkills.Add(new Skill("Fish Disection", false));
        }



        if (curretProfession.blacksmithing)
        {
            allSkills.Add(new Skill("Blacksmithing", true));
        }
        else
        {
            allSkills.Add(new Skill("Blacksmithing", false));
        }




        if (curretProfession.metalCrafting)
        {
            allSkills.Add(new Skill("Metal Crafting", true));
        }
        else
        {
            allSkills.Add(new Skill("Metal Crafting", false));
        }


        if (curretProfession.weaponSmithing)
        {
            allSkills.Add(new Skill("Weapon Smithing", true));
        }
        else
        {
            allSkills.Add(new Skill("Weapon Smithing", false));
        }


        if (curretProfession.clothesMaking)
        {
            allSkills.Add(new Skill("Clothes Making", true));
        }
        else
        {
            allSkills.Add(new Skill("Clothes Making", false));
        }

        if (curretProfession.leatherworking)
        {
            allSkills.Add(new Skill("Leatherworking", true));
        }
        else
        {
            allSkills.Add(new Skill("Leatherworking", false));
        }

        if (curretProfession.stoneCrafting)
        {
            allSkills.Add(new Skill("Stone Crafting", true));
        }
        else
        {
            allSkills.Add(new Skill("Stone Crafting", false));
        }


        if (curretProfession.woodCrafting)
        {

            allSkills.Add(new Skill("Wood Crafting", true));
        }
        else
        {
            allSkills.Add(new Skill("Wood Crafting", false));
        }



        if (curretProfession.pottery)
        {

            allSkills.Add(new Skill("Pottery", true));
        }
        else
        {
            allSkills.Add(new Skill("Pottery", false));
        }



        if (curretProfession.gemCutting)
        {
            allSkills.Add(new Skill("Gem Cutting", true));
        }
        else
        {
            allSkills.Add(new Skill("Gem Cutting", false));
        }



        if (curretProfession.gemSetting)
        {
            allSkills.Add(new Skill("Gem Setting", true));
        }
        else
        {

            allSkills.Add(new Skill("Gem Setting", false));
        }



        if (curretProfession.diagnostics)
        {
            allSkills.Add(new Skill("Diagnostics", true));
        }
        else
        {
            allSkills.Add(new Skill("Diagnostics", false));
        }


        if (curretProfession.woundDressing)
        {
            allSkills.Add(new Skill("Wound Dressing", true));
        }
        else
        {
            allSkills.Add(new Skill("Wound Dressing", false));
        }




        if (curretProfession.patientCare)
        {
            allSkills.Add(new Skill("Patient Care", true));
        }
        else
        {
            allSkills.Add(new Skill("Patient Care", false));
        }


        if (curretProfession.recoveringWounded)
        {
            allSkills.Add(new Skill("Recovering Wounded", true));
        }
        else
        {
            allSkills.Add(new Skill("Recovering Wounded", false));
        }



        if (curretProfession.suturing)
        {
            allSkills.Add(new Skill("Suturing", true));
        }
        else
        {
            allSkills.Add(new Skill("Suturing", false));
        }


        if (curretProfession.hauling)
        {
            allSkills.Add(new Skill("Hauling", true));
        }
        else
        {
            allSkills.Add(new Skill("Hauling", false));
        }

        foreach(Skill skill in allSkills)
        {
            if (skill.isTrained)
            {
                currentDwarfInfo.DwarfReport();
               // print("Skill List: ");
               //print(skill.Skillname + " " + skill.isTrained);
                currentDwarfSkills.Add(skill.Skillname);
                //skills.Add((Skill)skill);
            }
        }
    }

}




   




    



