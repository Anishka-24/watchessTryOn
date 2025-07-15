using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMangers : MonoBehaviour
{
    public GameObject watch1;
    public GameObject watch2;
    public GameObject watch3;
    public GameObject watch4;

    public GameObject watch1Window;
    public GameObject watch2Window;
    public GameObject watch3Window;
     public GameObject watch4Window;

    public Button watch1B;
    public Button watch2B;
    public Button watch3B;
    public Button watch4B;

    private void Start()
    {
        watch1B.onClick.AddListener(() =>
        {
            ActivateScreen(watch1, watch1Window);
        });
        watch2B.onClick.AddListener(() =>
       {
           ActivateScreen(watch2, watch2Window);
       });
        watch3B.onClick.AddListener(() =>
       {
           ActivateScreen(watch3, watch3Window);
       });
       watch4B.onClick.AddListener(() =>
       {
           ActivateScreen(watch4, watch4Window);
       });
    }
    private void ActivateScreen(GameObject watchToActivate, GameObject watchWindow)
    {
        watch1.SetActive(false);
        watch2.SetActive(false);
        watch3.SetActive(false);

        watch1Window.SetActive(false);
        watch2Window.SetActive(false);
        watch3Window.SetActive(false);

        watchToActivate.SetActive(true);
        watchWindow.SetActive(true);
    }


}
