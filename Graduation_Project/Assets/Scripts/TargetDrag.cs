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
            Debug.Log("Ýlk Tav deðdi sayýsý: "+pancount);
        }
        else
        {
            Debug.Log("Ýlk tava deðmedi tekrar dene");
        }
        if(pancount>=1 && collider.gameObject.CompareTag("oil"))
        {
            oilcount++;
            Debug.Log("ikinci tava deðdi tava deðme sayýsý: " + oilcount);
        }
        else
        {
            Debug.Log("ikinci yað deðmedi tekrar dene");
        }
        if (pancount >= 1 && oilcount >= 1 && collider.gameObject.CompareTag("egg"))
        {
            eggcount++;
            Debug.Log("en son yumurta deðdi deðme sayýsý: "+eggcount);
        }
        
        
    }
}
