using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillFinder : MonoBehaviour
{
    public DwarfData dwarfData;

    public ProfessionScriptableObject professionScriptableObject;

    public List<string> currentDwarfSkills = new List<string>();
    //public List<SkillFinder> currentDwarfSkills = new List<SkillFinder>();
    // Start is called before the first frame update
    void Start()
    {
        Skillchecker();
    }
    public void Skillchecker()
    {
        professionScriptableObject = dwarfData.currentDwarfProfession;

        List<Skill> skills = new List<Skill>();

        if (professionScriptableObject.mining)
        {
            skills.Add(new Skill("Mining", true));
        }
        else
        {
            skills.Add(new Skill("Mining", false));

        }


        if (professionScriptableObject.masonry)
        {
            skills.Add(new Skill("Masonry", true));
        }
        else
        {
            skills.Add(new Skill("Masonry", false));
        }


        if (professionScriptableObject.stoneDetailing)
        {
            skills.Add(new Skill("Stone Detailing", true));
        }
        else
        {
            skills.Add(new Skill("Stone Detailing", false));
        }



        if (professionScriptableObject.carpentry)
        {
            skills.Add(new Skill("Carpentry", true));
        }
        else
        {
            skills.Add(new Skill("Carpentry", false));
        }


        if (professionScriptableObject.woodCutting)
        {
            skills.Add(new Skill("Wood Cutting", true));
        }
        else
        {
            skills.Add(new Skill("Wood Cutting", false));
        }


        if (professionScriptableObject.plantGathering)
        {
            skills.Add(new Skill("Plant Gathering", true));
        }
        else
        {
            skills.Add(new Skill("Plant Gathering", false));

        }


        if (professionScriptableObject.plantProcessing)
        {
            skills.Add(new Skill("Plant Processing", true));
        }
        else
        {
            skills.Add(new Skill("Plant Processing", false));
        }


        if (professionScriptableObject.carpentry)
        {
            skills.Add(new Skill("Field Farming", true));
        }
        else
        {
            skills.Add(new Skill("Field Farming", false));
        }


        if (professionScriptableObject.fieldFarming)
        {
            skills.Add(new Skill("Field Farming", true));
        }
        else
        {
            skills.Add(new Skill("Field Farming", false));

        }

        if (professionScriptableObject.beekeeping)
        {

            skills.Add(new Skill("Beekeeping", true));
        }
        else
        {
            skills.Add(new Skill("Beekeeping", false));
        }


        if (professionScriptableObject.spinning)
        {
            skills.Add(new Skill("Spinning", true));
        }
        else
        {
            skills.Add(new Skill("Spinning", false));
        }


        if (professionScriptableObject.cooking)
        {
            skills.Add(new Skill("Cooking", true));
        }
        else
        {
            skills.Add(new Skill("Cooking", false));
        }


        if (professionScriptableObject.animalCare)
        {
            skills.Add(new Skill("AnimalCare", true));
        }
        else
        {
            skills.Add(new Skill("AnimalCare", false));
        }


        if (professionScriptableObject.animalTraining)
        {
            skills.Add(new Skill("Animal Training", true));
        }
        else
        {
            skills.Add(new Skill("Animal Training", false));
        }


        if (professionScriptableObject.trapping)
        {
            skills.Add(new Skill("Trapping", true));
        }
        else
        {
            skills.Add(new Skill("Trapping", false));
        }


        if (professionScriptableObject.butchery)
        {
            skills.Add(new Skill("Butchery", true));
        }
        else
        {
            skills.Add(new Skill("Butchery", false));
        }


        if (professionScriptableObject.fishing)
        {
            skills.Add(new Skill("Fishing", true));
        }
        else
        {

            skills.Add(new Skill("Fishing", false));
        }

        if (professionScriptableObject.fishCleaning)
        {
            skills.Add(new Skill("Fishing Cleaning", true));
        }
        else
        {

            skills.Add(new Skill("Fishing Cleaning", false));
        }

        if (professionScriptableObject.fishDisection)
        {
            skills.Add(new Skill("Fish Disection", true));
        }
        else
        {
            skills.Add(new Skill("Fish Disection", false));
        }



        if (professionScriptableObject.blacksmithing)
        {
            skills.Add(new Skill("Blacksmithing", true));
        }
        else
        {
            skills.Add(new Skill("Blacksmithing", false));
        }




        if (professionScriptableObject.metalCrafting)
        {
            skills.Add(new Skill("Metal Crafting", true));
        }
        else
        {
            skills.Add(new Skill("Metal Crafting", false));
        }


        if (professionScriptableObject.weaponSmithing)
        {
            skills.Add(new Skill("Weapon Smithing", true));
        }
        else
        {
            skills.Add(new Skill("Weapon Smithing", false));
        }


        if (professionScriptableObject.clothesMaking)
        {
            skills.Add(new Skill("Clothes Making", true));
        }
        else
        {
            skills.Add(new Skill("Clothes Making", false));
        }

        if (professionScriptableObject.leatherworking)
        {
            skills.Add(new Skill("Leatherworking", true));
        }
        else
        {
            skills.Add(new Skill("Leatherworking", false));
        }

        if (professionScriptableObject.stoneCrafting)
        {
            skills.Add(new Skill("Stone Crafting", true));
        }
        else
        {
            skills.Add(new Skill("Stone Crafting", false));
        }


        if (professionScriptableObject.woodCrafting)
        {

            skills.Add(new Skill("Wood Crafting", true));
        }
        else
        {
            skills.Add(new Skill("Wood Crafting", false));
        }



        if (professionScriptableObject.pottery)
        {

            skills.Add(new Skill("Pottery", true));
        }
        else
        {
            skills.Add(new Skill("Pottery", false));
        }



        if (professionScriptableObject.gemCutting)
        {
            skills.Add(new Skill("Gem Cutting", true));
        }
        else
        {
            skills.Add(new Skill("Gem Cutting", false));
        }



        if (professionScriptableObject.gemSetting)
        {
            skills.Add(new Skill("Gem Setting", true));
        }
        else
        {

            skills.Add(new Skill("Gem Setting", false));
        }



        if (professionScriptableObject.diagnostics)
        {
            skills.Add(new Skill("Diagnostics", true));
        }
        else
        {
            skills.Add(new Skill("Diagnostics", false));
        }


        if (professionScriptableObject.woundDressing)
        {
            skills.Add(new Skill("Wound Dressing", true));
        }
        else
        {
            skills.Add(new Skill("Wound Dressing", false));
        }




        if (professionScriptableObject.patientCare)
        {
            skills.Add(new Skill("Patient Care", true));
        }
        else
        {
            skills.Add(new Skill("Patient Care", false));
        }


        if (professionScriptableObject.recoveringWounded)
        {
            skills.Add(new Skill("Recovering Wounded", true));
        }
        else
        {
            skills.Add(new Skill("Recovering Wounded", false));
        }



        if (professionScriptableObject.suturing)
        {
            skills.Add(new Skill("Suturing", true));
        }
        else
        {
            skills.Add(new Skill("Suturing", false));
        }


        if (professionScriptableObject.hauling)
        {
            skills.Add(new Skill("Hauling", true));
        }
        else
        {
            skills.Add(new Skill("Hauling", false));
        }

        foreach(Skill skill in skills)
        {
            if (skill.isTrained)
            {
                dwarfData.DwarfReport();
               // print("Skill List: ");
               //print(skill.Skillname + " " + skill.isTrained);
                currentDwarfSkills.Add(skill.Skillname);
            }
        }
    }

}




   




    



