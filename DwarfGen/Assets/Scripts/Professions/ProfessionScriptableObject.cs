using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[CreateAssetMenu(fileName = "Profession Data", menuName = "ScriptableObjects/Profession", order = 1)]
public class ProfessionScriptableObject : ScriptableObject
{
    //work types as bools each indevidual profession has compatable work types / labours

    [Header("Mining")]
    public bool mining;

    [Header("Stoneworking")]
    public bool masonry;
    public bool stoneDetailing;

    [Header("Woodworking")]
    public bool carpentry;
    public bool woodCutting;

    [Header("Farming")]
    public bool plantGathering;
    public bool brewing;
    public bool plantProcessing;
    public bool fieldFarming;
    public bool beekeeping;
    public bool spinning;
    public bool cooking;



    [Header("Hunting")]
    public bool animalCare;
    public bool animalTraining;
    public bool trapping;
    public bool butchery;

    [Header("Fishing")]
    public bool fishing;
    public bool fishCleaning;
    public bool fishDisection;

    [Header("Smithing")]
    public bool blacksmithing;
    public bool metalCrafting;
    public bool weaponSmithing;

    [Header("Crafting")]
    public bool clothesMaking;
    public bool leatherworking;
    public bool stoneCrafting;
    public bool woodCrafting;
    public bool pottery;


    [Header("Jeweling")]
    public bool gemCutting;
    public bool gemSetting;


    [Header("Healthcare")]
    public bool diagnostics;
    public bool woundDressing;
    public bool patientCare;
    public bool surgery;
    public bool recoveringWounded;
    public bool suturing;

    [Header("Hauling")]
    public bool hauling;




}
