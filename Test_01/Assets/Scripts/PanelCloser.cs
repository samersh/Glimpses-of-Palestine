using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelCloser : MonoBehaviour
{
  public GameObject Panel;

public void OpenPanel()
{

    if (Panel != null)
    {

      //bool isActive = Panel.activeSelf;
       Panel.SetActive(false);
      //Panel.SetActive(!isActive);

    }


}
}
