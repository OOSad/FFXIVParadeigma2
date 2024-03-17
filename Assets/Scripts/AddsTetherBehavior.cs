using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEditor.EditorTools;
using UnityEngine;

public class AddsTetherBehavior : MonoBehaviour
{
    List<GameObject> addsTether;
    List<GameObject> waypoints;
    List<GameObject> partyMembers;
    int selectedSet;
    int addsTravelTime;
    float globalTimer;

    // Start is called before the first frame update
    void Start()
    {
        addsTether = new List<GameObject>();
        waypoints = new List<GameObject>();
        partyMembers = new List<GameObject>();
        selectedSet = UnityEngine.Random.Range(0, 2);
        addsTravelTime = 50;

        for (int i = 0; i < GameObject.FindGameObjectsWithTag("AddsTether").Count(); i++)
        {
            addsTether.Add(GameObject.FindGameObjectsWithTag("AddsTether")[i]);
        }

        for (int i = 0; i < GameObject.FindGameObjectsWithTag("Waypoint").Count(); i++)
        {
            waypoints.Add(GameObject.FindGameObjectsWithTag("Waypoint")[i]);
        }

        for (int i = 0; i < GameObject.FindGameObjectsWithTag("PartyMember").Count(); i++)
        
        {
            partyMembers.Add(GameObject.FindGameObjectsWithTag("PartyMember")[i]);
        }

        addsTether = addsTether.OrderBy(go => go.name).ToList();
        waypoints = waypoints.OrderBy(go => go.name).ToList();
        partyMembers = partyMembers.OrderBy(go => go.name).ToList();
    }

    // Update is called once per frame
    void Update()
    {
        globalTimer += Time.deltaTime;

        Debug.Log(globalTimer);

        if (globalTimer >= 3)
        {
            if (selectedSet == 0)
            {
                addsTether[0].transform.position = Vector3.MoveTowards(addsTether[0].transform.position, waypoints[0].transform.position, addsTravelTime * Time.deltaTime);
                addsTether[1].transform.position = Vector3.MoveTowards(addsTether[1].transform.position, waypoints[2].transform.position, addsTravelTime * Time.deltaTime);
                addsTether[2].transform.position = Vector3.MoveTowards(addsTether[2].transform.position, waypoints[4].transform.position, addsTravelTime * Time.deltaTime);
                addsTether[3].transform.position = Vector3.MoveTowards(addsTether[3].transform.position, waypoints[6].transform.position, addsTravelTime * Time.deltaTime);
            }

            else if (selectedSet == 1)
            {
                addsTether[0].transform.position = Vector3.MoveTowards(addsTether[0].transform.position, waypoints[1].transform.position, addsTravelTime * Time.deltaTime);
                addsTether[1].transform.position = Vector3.MoveTowards(addsTether[1].transform.position, waypoints[3].transform.position, addsTravelTime * Time.deltaTime);
                addsTether[2].transform.position = Vector3.MoveTowards(addsTether[2].transform.position, waypoints[5].transform.position, addsTravelTime * Time.deltaTime);
                addsTether[3].transform.position = Vector3.MoveTowards(addsTether[3].transform.position, waypoints[7].transform.position, addsTravelTime * Time.deltaTime);
            }

        }

        if (globalTimer >= 6)
        {

        }
        
        
    }
}
