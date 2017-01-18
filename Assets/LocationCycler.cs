using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class LocationCycler : MonoBehaviour
{
    public GameObject player;
    public List<Transform> playerLocations;

    private int currentPlayerLocationIdx;
    public int CurrentPlayerLocationIdx {
        get
        {
            return this.currentPlayerLocationIdx;
        }
        set
        {
            currentPlayerLocationIdx = value % playerLocations.Count;
            player.transform.position = playerLocations[currentPlayerLocationIdx].position;
        }
    }

    public void Start()
    {
        MagnetSensor.OnCardboardTrigger += () => NextLocation();
        currentPlayerLocationIdx = 0;
    }

    public void NextLocation()
    {
        CurrentPlayerLocationIdx++;
    }
}