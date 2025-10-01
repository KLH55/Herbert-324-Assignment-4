using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Example from Unity.com
public class ProductC : MonoBehaviour, IProduct
{
    [SerializeField]
    private string m_ProductName = "ProductC";

    public string ProductName { get => m_ProductName; set => m_ProductName = value; }

    public Material[] m_Materials;

    private Renderer m_Renderer;
    private int m_Index = 0;
    private bool m_Enabled = true;

    void Awake()
    {
        m_Renderer = GetComponent<Renderer>();

        if (m_Materials.Length > 0)
        {
            m_Renderer.material = m_Materials[m_Index];
        }
    }
    public void Initialize()
    {
        // Add any unique set up logic here
        gameObject.name = m_ProductName;

        StartCoroutine(Strobing());
        
        
    }

    private IEnumerator Strobing()
    {
        while (m_Enabled)
        {
            Strobe();
            yield return new WaitForSeconds(0.5f);
        }
    }

    public void Strobe()
    {
        m_Index = (m_Index + 1) % m_Materials.Length;
        m_Renderer.material = m_Materials[m_Index];
    }
}

