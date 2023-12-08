using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractNPC : MonoBehaviour
{

    private bool IsInteractable = false;
    private ScenesManager scenesmanager;

    private void Start()
    {
        scenesmanager = FindObjectOfType<ScenesManager>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        IsInteractable = true;
        Debug.Log("Is begun");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        IsInteractable = false;
        Debug.Log("Is ended");
    }

    private void Update()
    {
        if (IsInteractable == true && Input.GetKeyDown(KeyCode.E))
        {
            scenesmanager.LoadSceneOnIndex(2);
        }
    }
}
