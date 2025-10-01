using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Example from Unity.com
public class ProductC : MonoBehaviour, IProduct
{
    [SerializeField]
    private string m_ProductName = "ProductC";

    public string ProductName { get => m_ProductName; set => m_ProductName = value; }

    public void Initialize()
    {
        // Add any unique set up logic here
        gameObject.name = m_ProductName;
        
    }
}

