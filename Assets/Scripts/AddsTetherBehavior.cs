using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEditor.EditorTools;
using UnityEngine;

public class AddsTetherBehavior : MonoBehaviour
{
    public List<GameObject> addsTether;
    public List<GameObject> waypoints;
    public List<GameObject> partyMembers;
    int selectedSet;
    int addsTravelTime;
    float globalTimer;

    // Start is called before the first frame update
    void Start()
    {
        selectedSet = UnityEngine.Random.Range(0, 2);
        addsTravelTime = 50;
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
