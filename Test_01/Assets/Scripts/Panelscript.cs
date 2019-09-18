using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panelscript : MonoBehaviour
{
  public GameObject Panel1;
  public GameObject Panel2;

  public void OpenPanel()
  {

      if (Panel1 != null)
      {

         Panel1.SetActive(true);

      }


  }

  public void ClosePanel()
  {

      if (Panel1 != null)
      {


         Panel1.SetActive(false);


      }


  }

  public void OpenPanel2()
  {

      if (Panel2 != null)
      {

        //bool isActive = Panel.activeSelf;
         Panel2.SetActive(true);
        //Panel.SetActive(!isActive);

      }


  }

  public void ClosePanel2()
  {

      if (Panel2 != null)
      {


         Panel2.SetActive(false);


      }


  }

}
