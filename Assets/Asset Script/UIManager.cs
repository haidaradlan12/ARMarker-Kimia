using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [Header("UI Manager")]
    public RectTransform POpen; public RectTransform PMU, PMB, PMI, PPre, PQ, PS1, PS2, PS3, PS4, PS5, PH;
    public GameObject P1, P2, P3, P4, P5;
    [Header("Nilai")]
    public GameObject A0; public GameObject A1, A2, A3, A4, A5;
    [Header("Aktif tidak")]
    public GameObject BS1; public GameObject BS2, BS3, BS4, BS5;
    [Header("Quiz")]
    public GameObject Lan1; public GameObject Lan2, Lan3, Lan4, Lan5;
    [Header("Pretest")]
    public GameObject Kan1; public GameObject Kan2, Kan3, Kan4, Kan5;
    private int A, B, C, D, E, Total, BS;
    private int Varr;
    void Start()
    {
        POpen.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PMU.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PMB.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PMI.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PPre.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PQ.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PS1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PH.DOAnchorPos(new Vector2(0, -2500), 1.0f);
    }
    public void Button_AR()
    {
        POpen.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PMU.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PMB.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PMI.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PPre.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PQ.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PS1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PH.DOAnchorPos(new Vector2(0, -2500), 1.0f);
    }
    public void Button_MenuUtama()
    {
        POpen.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PMU.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PMB.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PMI.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PPre.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PQ.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PS1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PH.DOAnchorPos(new Vector2(0, -2500), 1.0f);
    }
    public void Button_MateriButton()
    {
        POpen.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PMU.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PMB.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PMI.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PPre.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PQ.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PS1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PH.DOAnchorPos(new Vector2(0, -2500), 1.0f);
    }
    public void Button_MateriIsi()
    {
        POpen.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PMU.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PMB.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PMI.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PPre.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PQ.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PS1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PH.DOAnchorPos(new Vector2(0, -2500), 1.0f);
    }
    public void Button_Pretest()
    {
        P1.SetActive(true);
        P2.SetActive(true);
        P3.SetActive(true);
        P4.SetActive(true);
        P5.SetActive(true);
        POpen.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PMU.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PMB.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PMI.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PPre.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PQ.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PS1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PH.DOAnchorPos(new Vector2(0, -2500), 1.0f);
    }
    public void Button_Quiz()
    {
        P1.SetActive(true);
        P2.SetActive(true);
        P3.SetActive(true);
        P4.SetActive(true);
        P5.SetActive(true);
        POpen.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PMU.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PMB.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PMI.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PPre.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PQ.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PS1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PH.DOAnchorPos(new Vector2(0, -2500), 1.0f);
    }
    public void Button_Soal1()
    {
        PS1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PS2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PH.DOAnchorPos(new Vector2(0, -2500), 1.0f);
    }
    public void Button_Soal2()
    {
        PS1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PS2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PS3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PH.DOAnchorPos(new Vector2(0, -2500), 1.0f);
    }
    public void Button_Soal3()
    {
        PS1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PS2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PS3.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PS4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PH.DOAnchorPos(new Vector2(0, -2500), 1.0f);
    }
    public void Button_Soal4()
    {
        PS1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PS2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PS3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PS4.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PS5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        PH.DOAnchorPos(new Vector2(0, -2500), 1.0f);
    }
    public void Button_Soal5()
    {
        PS1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PS2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PS3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PS4.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PS5.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PH.DOAnchorPos(new Vector2(0, -2500), 1.0f);
    }
    public void Button_Hasil()
    {
        PH.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PS1.DOAnchorPos(new Vector2(-1500, -2500), 0.0f);
        PS2.DOAnchorPos(new Vector2(-1500, -2500), 0.0f);
        PS3.DOAnchorPos(new Vector2(-1500, -2500), 0.0f);
        PS4.DOAnchorPos(new Vector2(-1500, -2500), 0.0f);
        PS5.DOAnchorPos(new Vector2(-1500, -2500), 0.0f);
        
    }
    //logic soal
    void Update()
    {
        Total = (A + B + C + D + E);
        if (Total == 0)
        {
            A0.SetActive(true);
            A1.SetActive(false);
            A2.SetActive(false);
            A3.SetActive(false);
            A4.SetActive(false);
            A5.SetActive(false);
        }
        else if (Total == 1)
        {
            A0.SetActive(false);
            A1.SetActive(true);
            A2.SetActive(false);
            A3.SetActive(false);
            A4.SetActive(false);
            A5.SetActive(false);
        }
        else if (Total == 2)
        {
            A0.SetActive(false);
            A1.SetActive(false);
            A2.SetActive(true);
            A3.SetActive(false);
            A4.SetActive(false);
            A5.SetActive(false);
        }
        else if (Total == 3)
        {
            A0.SetActive(false);
            A1.SetActive(false);
            A2.SetActive(false);
            A3.SetActive(true);
            A4.SetActive(false);
            A5.SetActive(false);
        }
        else if (Total == 4)
        {
            A0.SetActive(false);
            A1.SetActive(false);
            A2.SetActive(false);
            A3.SetActive(false);
            A4.SetActive(true);
            A5.SetActive(false);
        }
        else if (Total == 5)
        {
            A0.SetActive(false);
            A1.SetActive(false);
            A2.SetActive(false);
            A3.SetActive(false);
            A4.SetActive(false);
            A5.SetActive(true);
        }

        if (BS==1)
        {
            BS1.SetActive(true);
            BS2.SetActive(true);
            BS3.SetActive(true);
            BS4.SetActive(true);
            BS5.SetActive(true);
            Lan1.SetActive(true);
            Lan2.SetActive(true);
            Lan3.SetActive(true);
            Lan4.SetActive(true);
            Lan5.SetActive(true);
            Kan1.SetActive(false);
            Kan2.SetActive(false);
            Kan3.SetActive(false);
            Kan4.SetActive(false);
            Kan5.SetActive(false);
        }
        else if (BS==2)
        {
            BS1.SetActive(false);
            BS2.SetActive(false);
            BS3.SetActive(false);
            BS4.SetActive(false);
            BS5.SetActive(false);
            Lan1.SetActive(false);
            Lan2.SetActive(false);
            Lan3.SetActive(false);
            Lan4.SetActive(false);
            Lan5.SetActive(false);
            Kan1.SetActive(true);
            Kan2.SetActive(true);
            Kan3.SetActive(true);
            Kan4.SetActive(true);
            Kan5.SetActive(true);
        }
    }
    public void soal1(int nilai)
    {
        A = nilai;
    }
    public void soal2(int nilai)
    {
        B = nilai;
    }
    public void soal3(int nilai)
    {
        C = nilai;
    }
    public void soal4(int nilai)
    {
        D = nilai;
    }
    public void soal5(int nilai)
    {
        E = nilai;
    }
    public void resetnilai()
    {
        P1.SetActive(false);
        P2.SetActive(false);
        P3.SetActive(false);
        P4.SetActive(false);
        P5.SetActive(false);
        A = 0;
        B = 0;
        C = 0;
        D = 0;
        E = 0;
    }
    public void BS_nilai(int nilai)
    {
        BS = nilai;
    }
}
