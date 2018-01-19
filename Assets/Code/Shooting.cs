using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Shooting : MonoBehaviour 
{
    [SerializeField]
    private GameObject BulletPrefab;

    [SerializeField]
    private Transform BulletInstPos;

    [SerializeField]
    private bool _IsTriggerDown;

    private EVRButtonId _TriggerButton = EVRButtonId.k_EButton_SteamVR_Trigger;

    private SteamVR_Controller.Device _Controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }

    [SerializeField]
    private SteamVR_TrackedObject trackedObj;

    /// <summary>
    ///	Script entry point.
    /// </summary>
    private void Start () 
	{
        trackedObj = GetComponent<SteamVR_TrackedObject>(); 
	}

    /// <summary>
    /// Script main loop.
    /// </summary>
    void Update()
    {
        if (_Controller == null)
        {
            Debug.Log("Controller not initialized");
            return;
        }

        _IsTriggerDown = _Controller.GetPress(_TriggerButton);

        if (_IsTriggerDown)
        {
            Instantiate(BulletPrefab, BulletInstPos);
        }
    }
}

