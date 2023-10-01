using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewToggleTrigger : MonoBehaviour
{
    SideViewManager sideViewManager;
    public Transform exitPoint;


    private void Start()
    {
        sideViewManager = GameObject.FindObjectOfType<SideViewManager>();
    }

    public void Toggle()
    {
        sideViewManager.ToggleView();
    }
}
