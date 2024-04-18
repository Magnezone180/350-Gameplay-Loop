using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractableLifter : MonoBehaviour
{
    [SerializeField] private XRGrabInteractable grabInteractable; // Reference to the XRGrabInteractable component
    [SerializeField] private XRSocketInteractor socketInteractor; // Reference to the XRSocketInteractor component
    [SerializeField] private Transform[] blocksToLift; // Array of Transforms for the blocks to lift
    [SerializeField] private float liftDistance = 0.5f; // Distance each block will be lifted (adjustable)

    private bool isLifted = false; // Flag to track if the blocks are currently lifted

    private void Awake()
    {
        // Ensure references are assigned in the Inspector
        if (grabInteractable == null)
        {
            Debug.LogError("XRGrabInteractable reference not assigned in " + name);
        }

        if (socketInteractor == null)
        {
            Debug.LogError("XRSocketInteractor reference not assigned in " + name);
        }

        if (blocksToLift == null || blocksToLift.Length == 0)
        {
            Debug.LogError("No blocks assigned to lift in " + name);
        }
    }

    private void OnEnable()
    {
        grabInteractable.onSelectEntered.AddListener(OnGrabEntered); // Listen for grab enter event
        grabInteractable.onSelectExited.AddListener(OnGrabExited);  // Listen for grab exit event
    }

    private void OnDisable()
    {
        grabInteractable.onSelectEntered.RemoveListener(OnGrabEntered);
        grabInteractable.onSelectExited.RemoveListener(OnGrabExited);
    }

    private void OnGrabEntered(XRBaseInteractor interactor)
    {
        // Check if the grabber is the socket interactor
        if (interactor == socketInteractor)
        {
            isLifted = true;
            LiftBlocks();
        }
    }

    private void OnGrabExited(XRBaseInteractor interactor)
    {
        // Check if the grabber is the socket interactor
        if (interactor == socketInteractor && isLifted)
        {
            isLifted = false;
            LowerBlocks();
        }
    }

    private void LiftBlocks()
    {
        if (blocksToLift != null)
        {
            foreach (Transform block in blocksToLift)
            {
                block.position += Vector3.up * liftDistance; // Lift each block
            }
        }
    }

    private void LowerBlocks()
    {
        if (blocksToLift != null)
        {
            foreach (Transform block in blocksToLift)
            {
                block.position -= Vector3.up * liftDistance; // Lower each block
            }
        }
    }
}

