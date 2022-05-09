using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSwitch : Interactable
{
    public GameObject item;
    public AudioClip pickUpSound;
    public AudioSource audioSource;

    public override void OnInteraction()
    {
        item.SetActive(true);
        PlaySFX();
    }
    public void PlaySFX()
    {
        audioSource.clip = pickUpSound;
        audioSource.Play();
    }
}
