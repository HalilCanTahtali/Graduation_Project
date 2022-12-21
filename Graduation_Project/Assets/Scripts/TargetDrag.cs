using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TargetDrag : MonoBehaviour
{
    private int pancount, oilcount, eggcount;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("pan"))
        {
            pancount++;
            Debug.Log("�lk Tav de�di say�s�: "+pancount);
        }
        else
        {
            Debug.Log("�lk tava de�medi tekrar dene");
        }
        if(pancount>=1 && collider.gameObject.CompareTag("oil"))
        {
            oilcount++;
            Debug.Log("ikinci tava de�di tava de�me say�s�: " + oilcount);
        }
        else
        {
            Debug.Log("ikinci ya� de�medi tekrar dene");
        }
        if (pancount >= 1 && oilcount >= 1 && collider.gameObject.CompareTag("egg"))
        {
            eggcount++;
            Debug.Log("en son yumurta de�di de�me say�s�: "+eggcount);
        }
        
        
    }
}
