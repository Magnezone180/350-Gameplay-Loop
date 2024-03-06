using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerWalk : MonoBehaviour
{
    private AudioSource audioSource;

    private Vector3 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
      audioSource = GetComponent<AudioSource>();
      lastPosition = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != lastPosition && !audioSource.isPlaying)
        {
            audioSource.pitch = Random.Range(0.9f, 1.2f);
            audioSource.volume = Random.Range(0.4f, 1f);
            audioSource.Play();
        }
        lastPosition = transform.position;
    }
}
