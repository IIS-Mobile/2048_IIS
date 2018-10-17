using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManagerSimple : MonoBehaviour {



    //--------------------------------------
    // ADS HANDLING
    //--------------------------------------

    public void ShowAdNonSkipable()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show("rewardedVideo");
        }
    }

    public void ShowAdSkipable()
    {
        if (Advertisement.IsReady("video"))
        {
            Advertisement.Show("video");
        }
    }

}
