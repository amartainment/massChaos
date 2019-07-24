﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerSlotsManager : MonoBehaviour
{
    public GameObject[] Slots;
    List<BaseCharachteristics> FollowerList = NPCSystem.followers;

    void Start()
    {
        DecideonNumberofSlotsperFollower();
        FillSlots();
    }

    


    //TO TURN OFF ALL FOLLOWER SLOTS THAT DON'T HOLD ANY VALUE BY TURNING OFF ALL PAST THE SIZE OF THE FOLLOWERLIST
    public void DecideonNumberofSlotsperFollower()
    {
        int NumberofSlots = FollowerList.Count;

        foreach(GameObject Slot in Slots)
        {
            if (NumberofSlots > 0)
                Slot.SetActive(true);
            else
                Slot.SetActive(false);

            NumberofSlots--;
        }

    }

    //FILLS FOLLOWER SLOTS WITH VALUES
    //id, name, type, classType, secItem, priItem, status
    public void FillSlots()
    {
        int count = 0;
        foreach (var item in FollowerList)
        {
            

            //Change the variables of each Slot in the array.
            Slots[count].GetComponent<FollowerSlot>().FollowerName = item.name;
            Slots[count].GetComponent<FollowerSlot>().FollowerRace = item.type;
            Slots[count].GetComponent<FollowerSlot>().FollowerClass = item.classType.ToString();
            Slots[count].GetComponent<FollowerSlot>().FollowerPrimaryWeapon = item.priItem;
            Slots[count].GetComponent<FollowerSlot>().FollowerSecondaryWeapon = item.secItem;
            Slots[count].GetComponent<FollowerSlot>().FollowerStatus = item.status;

            Slots[count].GetComponent<FollowerSlot>().FillSlots();
            count++;
        }
    }
}