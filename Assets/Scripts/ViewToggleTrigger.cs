using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewToggleTrigger : MonoBehaviour
{
    SideViewManager sideViewManager;
    [SerializeField]SideViewManager.ObstacleType type;

    private void Start()
    {
        sideViewManager = GameObject.FindObjectOfType<SideViewManager>();
    }

    public void Toggle()
    {
        sideViewManager.ToggleView(type);
    }
}
