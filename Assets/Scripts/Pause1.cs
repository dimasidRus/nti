using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Pause1 : MonoBehaviour
{
    public SteamVR_ActionSet m_ActionSet;
    public ISteamVR_Action_Boolean m_BooleanAction;
    public GameObject PauseUI;
    /*private void Awake()
    {
        m_BooleanAction= SteamVR_Action._default.GrabPinch;
    }*/
    private void Start()
    {
        
        m_ActionSet.Activate(SteamVR_Input_Sources.Any, 0, true);

    }
    private bool pause = false;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pause = !pause;
            if (pause)
            {
                PauseUI.SetActive(true);
                Time.timeScale = 1;
            }
            else {
                PauseUI.SetActive(false);
    Time.timeScale = 0;
        }
        }


    }
}
