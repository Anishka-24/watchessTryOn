using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Watchwindows : MonoBehaviour
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
