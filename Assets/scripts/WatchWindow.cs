using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WatchWindow : MonoBehaviour
{
    [SerializeField] Button closeButton;
    void Start()
    {
        closeButton.onClick.AddListener(() =>
         {
             gameObject.SetActive(false);
         });
    }

   
}
