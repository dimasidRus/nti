using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Pause : MonoBehaviour
{
    public SteamVR_ActionSet m_ActionSet;
    public ISteamVR_Action_Boolean m_BooleanAction;
    public GameObject PauseUI;
    
    private void Start()
    {
        PauseUI.SetActive(false);
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
                PauseUI.SetActive(false);
                Time.timeScale = 1;
            }
            else {
                PauseUI.SetActive(true);
    Time.timeScale = 0;
        }
        }


    }
}
