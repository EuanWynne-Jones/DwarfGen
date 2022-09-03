using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "FirstName Data", menuName = "ScriptableObjects/FirstNames", order = 1)]
public class FirstName : ScriptableObject
{
    public List<string> prefix = new List<string>();
    public List<string> suffix = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
