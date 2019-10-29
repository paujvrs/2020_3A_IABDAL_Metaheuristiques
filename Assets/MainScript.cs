using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    [SerializeField]
    private Transform[] cubes;
    
    // Start is called before the first frame update
    private void Start() 
    {
        Debug.Log($"Hello les 3A IABDAL !!! :)");
        Debug.Log($"Il y a {cubes.Length} cubes dans la scene !!!");
    }
}