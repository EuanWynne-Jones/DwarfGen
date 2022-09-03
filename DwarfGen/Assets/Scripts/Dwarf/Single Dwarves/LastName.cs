using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Lastname Data", menuName = "ScriptableObjects/LastNames", order = 1)]
public class LastName : ScriptableObject
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
