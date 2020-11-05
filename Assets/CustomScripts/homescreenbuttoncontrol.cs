using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homescreenbuttoncontrol : MonoBehaviour
{
   public void showNearBy()
    {
        SceneManager.LoadScene("ARFoundationScene");
    }

    public void searchAround()
    {
        SceneManager.LoadScene("arlocationfinaltested");
    }

    public void photoGallery()
    {
        SceneManager.LoadScene("SimpleAR");
    }

    public void scanTarget()
    {
        SceneManager.LoadScene("scanTarget");
    }

    public void MainnavHome()
    {
        SceneManager.LoadScene("MainnavHome");
    }
}
