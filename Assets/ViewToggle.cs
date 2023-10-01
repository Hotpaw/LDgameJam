using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewToggle : MonoBehaviour
{
    [SerializeField]GameObject tdview, sview;



    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ToggleView();
        }
    }

    public void ToggleView()
    {
        if (tdview.activeSelf)
        {
            tdview.SetActive(false);
            sview.SetActive(true);
        }
        else
        {
            tdview.SetActive(true);
            sview.SetActive(false);
        }
    }

}
