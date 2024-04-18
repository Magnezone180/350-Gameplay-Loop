using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LiftBlock : MonoBehaviour
{
    public XRGrabInteractable grabInteractable;
    public Transform liftingTarget;
    public float liftSpeed = 1.0f;

    private bool isLifting = false;

    void Start()
    {
        if (grabInteractable == null)
        {
            grabInteractable = GetComponent<XRGrabInteractable>();
        }

        if (grabInteractable == null)
        {
            Debug.LogError("XR Grab Interactable component not found!");
        }

        // Subscribe to the XR Grab Interactable events
        grabInteractable.onSelectEntered.AddListener(OnGrab);
        grabInteractable.onSelectExited.AddListener(OnRelease);
    }

    void Update()
    {
        // If the block is being lifted, move it towards the lifting target
        if (isLifting)
        {
            float step = liftSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, liftingTarget.position, step);
        }
    }

    // Called when the block is grabbed
    private void OnGrab(XRBaseInteractor interactor)
    {
        isLifting = true;
    }

    // Called when the block is released
    private void OnRelease(XRBaseInteractor interactor)
    {
        isLifting = false;
    }
}
