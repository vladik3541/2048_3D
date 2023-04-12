using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Record : MonoBehaviour
{
    Cube cube;
    [SerializeField] private int bestDrafting;
    private void Start()
    {
        cube = GetComponent<Cube>();
    }
    private void Update()
    {
        RecordData();
    }

    private void RecordData() {
        if(PlayerPrefs.HasKey("bestDrafting"))
            bestDrafting = PlayerPrefs.GetInt("bestDrafting");
        if(bestDrafting <= cube.CubeNumber)
        {
            PlayerPrefs.SetInt("bestDrafting", cube.CubeNumber);
            PlayerPrefs.Save();
        }

            
        
    }
}
