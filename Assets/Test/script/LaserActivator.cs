using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class LaserActivator : MonoBehaviour
{
    [SerializeField] GhostHand gh;
    SteamVR_Action_Boolean grab;
    SteamVR_Behaviour_Pose pose;

    // Start is called before the first frame update
    void Start()
    {   
        grab = SteamVR_Actions._default.GrabGrip;
        pose = GetComponent<SteamVR_Behaviour_Pose>();
    }

    // Update is called once per frame
    void Update()
    {
        if (grab.GetState(pose.inputSource))
            gh.holder.SetActive(true);
        else
            gh.holder.SetActive(false);
    }
}
