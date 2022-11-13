using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutSellTray : MonoBehaviour // Æ®·¹ÀÌ ÀÎ½Ä½ºÅ©¸³Æ®
{

    public int i = 0;
    public int Kb = 0; // ±è¹ä
    public int Fc = 0; // ¾î¹¬
    public int Rc = 0; // ¶±ººÀÌ
    public int Pa = 0; // ÆÄÀü
    public int TutC = 0; // ÆÐÅÏ Á¤¸®¿ë
    public int count = 0;

    public GameObject Circle1;
    public GameObject Circle2;
    public GameObject Circle3;

    private void OnTriggerEnter(Collider collider)
    {
        i = 1;

        if (collider.gameObject.tag == "Kbob")
        {
            Kb = Kb + i;
            //Debug.Log("±è¹ä °¹¼ö : " + Kb);
        }
        if (collider.gameObject.tag == "Fcake")
        {
            Fc = Fc + i;
            //Debug.Log("¾î¹¬ °¹¼ö : " + Fc);
        }
        if (collider.gameObject.tag == "Rcake")
        {
            Rc = Rc + i;
            //Debug.Log("¶±ººÀÌ °¹¼ö : " + Rc);
        }
        if (collider.gameObject.tag == "Pajun")
        {
            Pa = Pa + i;
            //Debug.Log("ÆÄÀü °¹¼ö : " + Pa);
        }
        count = count + 1;
        if (TutC == 0)
        {
            Debug.Log("2) Á¦Ãâ ¹öÆ°À» ´©¸£¸é ´ÙÀ½ ÁÖ¹®À¸·Î ³Ñ¾î°©´Ï´Ù.");
            TutC = 1;
        }
    }
    private void OnTriggerExit(Collider other) // µµ¸¶¿¡¼­ ³»·Á°¡¸é Ä«¿îÆ® -1
    {
        i = -1;

        if (other.gameObject.tag == "Kbob")
        {
            Kb = Kb + i;
            //Debug.Log("±è¹ä °¹¼ö : " + Kb);
        }
        if (other.gameObject.tag == "Fcake")
        {
            Fc = Fc + i;
            //Debug.Log("¾î¹¬ °¹¼ö : " + Fc);
        }
        if (other.gameObject.tag == "Rcake")
        {
            Rc = Rc + i;
            //Debug.Log("¶±ººÀÌ °¹¼ö : " + Rc);
        }
        if (other.gameObject.tag == "Pajun")
        {
            Pa = Pa + i;
            //Debug.Log("ÆÄÀü °¹¼ö : " + Pa);
        }
        count = count - 1;

    }

    private int iPlusMinus(int TagName, int j)
    {
        return TagName = TagName + j;
    }


    void Awake()
    {
        Debug.Log("1) ¿©±â¿¡ À½½ÄµéÀ» ¿Ã·Áº¸¼¼¿ä.");
    }

    void Update()
    {

        if (Pa == 1 && Rc == 1)
        {
            if (TutC == 2)
            {
                Circle2.SetActive(false);
                Circle3.SetActive(true);
                Debug.Log("4) Á¦Ãâ ¹öÆ°À» ´­·¯ÁÖ¼¼¿ä.");
                TutC = 3;
            }
        }
        if (TutC == 3 && Pa != 1 && Rc != 1)
        {
            TutC = 2;
        }
    }
}
