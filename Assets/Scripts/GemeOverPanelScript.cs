using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemeOverPanelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void Awake ()
    {

    }
	
	// Update is called once per frame
	void Update () {

        if (PlayerPrefs.GetInt("AddsRemoved") == 1)
        {

            try
            {
                GameObject banner;
                banner = GameObject.Find("AdBanner");
                banner.SetActive(false);
            }
            catch
            {

            }

        }
		
	}
}
