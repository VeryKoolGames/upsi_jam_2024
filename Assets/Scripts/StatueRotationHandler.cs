using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class StatueRotationHandler : MonoBehaviour
{
    [SerializeField] private VerifyStatues _verifyStatues;
    public Orientation currentOrientation;
    [SerializeField] private Orientation startOrientation;
    [SerializeField] private AudioSource rotateSound;
    private bool isRotating;
    private float currentRotation;
    private float targetRotation;
    private float rotationSpeed = 40.0f;

    private void Start()
    {
        currentOrientation = startOrientation;
        currentRotation = transform.rotation.y;
    }

    private void Update()
    {
        if (isRotating)
        {
            currentRotation += rotationSpeed * Time.deltaTime;
        
            if (currentRotation >= targetRotation)
            {
                currentRotation = targetRotation; // Corrects the overshoot to make sure it ends exactly at targetRotation
                isRotating = false; // Stops the rotation
                currentOrientation++;
                if (currentOrientation > Orientation.SOUTH)
                {
                    currentOrientation = Orientation.EAST;
                }
                _verifyStatues.VerifyStatuesOrientation();
                StartCoroutine(FadeOutCoroutine(1f));
            }

            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
    }

    private void OnMouseDown()
    {
        if (!isRotating)
        {
            targetRotation = currentRotation + 90;
            rotateSound.Play();
        }
        isRotating = true;
    }
    

    private IEnumerator FadeOutCoroutine(float duration)
    {
        float startVolume = rotateSound.volume;

        while (rotateSound.volume > 0)
        {
            rotateSound.volume -= startVolume * Time.deltaTime / duration;
            yield return null;
        }

        rotateSound.Stop();
        rotateSound.volume = startVolume; // Optionally reset the volume back to start volume if you plan to play it again
    }
    
}
