﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateDrops : MonoBehaviour
{
    public GameObject dungeonGold;
    public static int dungeonNumber = 1;
    public GameObject dungeonAprefab;
    public GameObject dungeonBprefab;
    public GameObject dungeonCprefab;
    public GameObject dungeonDprefab;

    // Start is called before the first frame update
    void Awake()
    {


        dropGold(1, 1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void dropGold(int enemyType, int enemyLevel,float enemyLocationX,float enemyLocationY)                               //drops gold based on enemy type and its level(basically dungeon runs). you need to pass
    {                                                                                                                           //enemy type, enemy level amd player location(x,y)
        float n = 0;
        for (int i = 0; i < enemyType; i++)
        {
            for (int j = 0; j < enemyLevel; j++)
            {

                Instantiate(dungeonGold, new Vector2(enemyLocationX + n, enemyLocationY + n), Quaternion.identity);
                n += 0.3f;
            }
        }

        if(dungeonNumber==0)
        {
            //dungeonAprefab.gameObject.SetActive(true);
            //Instantiate(dungeonAprefab, new Vector2(enemyLocationX + n, enemyLocationY + n), Quaternion.identity);
            GameObject A = dungeonAprefab.gameObject.GetComponent<TreasureChest>().CheckLootNearChest() as GameObject;
            A.gameObject.GetComponent<TreasureChest>().DropLootNearChest(1);
        }

        if (dungeonNumber == 1)
        {
            //dungeonBprefab.gameObject.SetActive(true);
            //Instantiate(dungeonBprefab, new Vector2(enemyLocationX + n, enemyLocationY + n), Quaternion.identity);
            GameObject B = dungeonAprefab.gameObject.GetComponent<TreasureChest>().CheckLootNearChest() as GameObject;
            B.gameObject.GetComponent<TreasureChest>().DropLootNearChest(1);
        }
        if (dungeonNumber == 2)
        {
            //dungeonCprefab.gameObject.SetActive(true);
            //Instantiate(dungeonCprefab, new Vector2(enemyLocationX + n, enemyLocationY + n), Quaternion.identity);
            GameObject C = dungeonAprefab.gameObject.GetComponent<TreasureChest>().CheckLootNearChest() as GameObject;
            C.gameObject.GetComponent<TreasureChest>().DropLootNearChest(1);
        }
        if (dungeonNumber == 3)
        {
            //dungeonDprefab.gameObject.SetActive(true);
            // Instantiate(dungeonDprefab, new Vector2(enemyLocationX + n, enemyLocationY + n), Quaternion.identity);
            GameObject D = dungeonAprefab.gameObject.GetComponent<TreasureChest>().CheckLootNearChest() as GameObject;
            D.gameObject.GetComponent<TreasureChest>().DropLootNearChest(1);
        }
    }


}
