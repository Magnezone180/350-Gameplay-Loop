using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LiftBlocksOnGrab : MonoBehaviour
{
    public Transform block1;
    public Transform block2;
    public float liftHeight = 2f;

    private void OnTriggerEnter(Collider other)
    {
        XRGrabInteractable grabInteractable = other.GetComponent<XRGrabInteractable>();

        // Check if the collider entering the trigger is an XR grab interactable
        if (grabInteractable != null)
        {
            // Lift both blocks
            LiftBlock(block1);
            LiftBlock(block2);
        }
    }

    private void LiftBlock(Transform block)
    {
        // Move the block upwards by liftHeight units
        block.Translate(Vector3.up * liftHeight);
    }
}