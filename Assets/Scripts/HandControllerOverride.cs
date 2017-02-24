using UnityEngine;
using System.Collections;


[RequireComponent(typeof(SteamVR_TrackedObject))]

public class HandControllerOverride : MonoBehaviour
{
    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;

    private Animator animator;

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        device = SteamVR_Controller.Input((int)trackedObj.index);
        animator.SetBool("isGrabbing", device.GetPress(SteamVR_Controller.ButtonMask.Trigger));
    }
}

