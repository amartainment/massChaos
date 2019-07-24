﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

using UnityEngine.UI;

public class NPCApplicants : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ApplicantItems;
    static int id = 0;
    string type;
    public GameObject can;
    public static List<BaseCharachteristics> applicants = new List<BaseCharachteristics>();

    void Start()
    {


        addFollower("Kroos", "M", "", "", "", "");
        addFollower("Froos", "Fo", "", "", "", ""); 



        foreach (var o in applicants)
        {

            GameObject go = (GameObject)Instantiate(ApplicantItems);
            go.transform.SetParent(this.transform);
            go.transform.Find("name").GetComponent<Text>().text = o.Name;
            go.transform.Find("id").GetComponent<Text>().text = o.Id.ToString();

            switch (o.Type)
            {
                case "N":                   
                    type = "Nomad";
                    go.transform.Find("affinity").GetComponent<Text>().text = "Combat";
                    break; 
                case "Fr":
                   
                    type = "Ferrarium";
                    go.transform.Find("affinity").GetComponent<Text>().text = "Trade";
                    break;
                case "Fo":
                  
                    type = "Froot";
                    go.transform.Find("affinity").GetComponent<Text>().text = "Farming";
                    break;
                case "M":
                    
                    type = "Mimax";
                    go.transform.Find("affinity").GetComponent<Text>().text = "Defence";
                    break;
            }


             go.transform.Find("type").GetComponent<Text>().text = type;
            //go.transform.Find("foodIntake").GetComponent<Text>().text = o.FoodIntake.ToString();
        }
    }

    public static BaseCharachteristics GetFollowerByID(int id)
    {

        BaseCharachteristics b = null;
        foreach (var o in applicants)
        {
            if (o.id == id)
            {
                b = o;
            }
        }
        return b;
    }


    public void onMenuItemClicked() {
        Debug.Log("Clicked");
        
    }



    public void onExitClick()
    {
        Debug.Log("mouse2");
        GameObject[] entries = GameObject.FindGameObjectsWithTag("NPCEntry");
        foreach (GameObject go in entries)
        {
            Destroy(go);
        }
        can.SetActive(false);
    }


    public static void removeFollower(int id)
    {
        int index = id - 1;
        applicants.RemoveAt(index);

    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void addFollower(string name, string type, string classType, string secItem, string priItem, string status)
    {
        id++;
        applicants.Add(new BaseCharachteristics(id, name, type, classType, secItem, priItem, status));


    }
}
