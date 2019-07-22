﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrtHIUIscript : MonoBehaviour
{

	private float CurrentFrtHappiness;
    public Image FrtHappiness;
	private GameObject FrtHI;

    // Start is called before the first frame update
    void Start()
    {
		FrtHappiness = GetComponent<Image>();
		FrtHI = GameObject.Find("FrootHI");
    }


	void ReadjustFrtHappiness()
	{
		CurrentFrtHappiness = FrtHI.GetComponent<FrootHappinessIndex>().FrootHappiness;
		FrtHappiness.fillAmount = CurrentFrtHappiness/10 ;
	}


    // Update is called once per frame
    void Update()
    {
        ReadjustFrtHappiness();
    }
}