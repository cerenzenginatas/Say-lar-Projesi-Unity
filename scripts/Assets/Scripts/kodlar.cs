using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class kodlar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int sayi1 = -20;
        int sayi2 = 60;
        //Bolenler(sayi1,sayi2);
        print(ButunDeger(sayi1, sayi2));
        print(ikiyeBolum(sayi1, sayi2));
        print(UceBolum(sayi1, sayi2));
        print(DordeBolum(sayi1, sayi2));
        print(BeseBolum(sayi1, sayi2));
    }
    void Bolenler(int sayi1, int sayi2)
    {
        if ( sayi2<=sayi1)
        {
            int gecici = sayi1;
            sayi1 = sayi2;
            sayi2 = gecici;
            
        }
        string sayilar = "";
        string ikiye_bolunenler = "";
        string uce_bolunenler = "";
        string dorde_bolunenler = "";
        string bese_bolunenler = "";
        for (int i = sayi1; i <= sayi2; i++)
        {
            sayilar = sayilar + " - " + i.ToString();
        }

        for (int i = sayi1; i <= sayi2; i++)
        {
            if (i % 2 == 0) { ikiye_bolunenler = ikiye_bolunenler + " - " + i.ToString();}
            
        }

        for (int i = sayi1; i <= sayi2; i++)
        {
            if (i % 3 == 0) { uce_bolunenler = uce_bolunenler + " - " + i.ToString(); }

        }

        for (int i = sayi1; i <= sayi2; i++)
        {
            if (i % 4 == 0) { dorde_bolunenler = dorde_bolunenler + " - " + i.ToString(); }

        }

        for (int i = sayi1; i <= sayi2; i++)
        {
            if (i % 5 == 0) { bese_bolunenler = bese_bolunenler + " - " + i.ToString(); }

        }
        print(sayilar);
        print(ikiye_bolunenler);
        print(uce_bolunenler);
        print(dorde_bolunenler);
        print(bese_bolunenler);
    }
    string ButunDeger(int sayi1, int sayi2)
    {
        if (sayi2 <= sayi1)
        {
            int gecici = sayi1;
            sayi1 = sayi2;
            sayi2 = gecici;

        }
        string sayilar = "";
        for (int i = sayi1; i <= sayi2; i++)
        {
            sayilar = sayilar + "-" + i.ToString();
        }
        return sayilar;
    }
    string ikiyeBolum(int sayi1, int sayi2)
    {
        if (sayi2 <= sayi1)
        {
            int gecici = sayi1;
            sayi1 = sayi2;
            sayi2 = gecici;

        }
        string sayilar = "";
        for (int i = sayi1; i <= sayi2; i++)
        {
            if (i % 2 == 0)
            {
                sayilar = sayilar + "-" + i.ToString();
            }
        }
        return sayilar;
    }
    string UceBolum(int sayi1, int sayi2)
    {
        if (sayi2 <= sayi1)
        {
            int gecici = sayi1;
            sayi1 = sayi2;
            sayi2 = gecici;

        }
        string sayilar = "";
        for (int i = sayi1; i <= sayi2; i++)
        {
            if (i % 3 == 0)
            {
                sayilar = sayilar + "-" + i.ToString();
            }
        }
        return sayilar;
    }
    string DordeBolum(int sayi1, int sayi2)
    {
        if (sayi2 <= sayi1)
        {
            int gecici = sayi1;
            sayi1 = sayi2;
            sayi2 = gecici;

        }
        string sayilar = "";
        for (int i = sayi1; i <= sayi2; i++)
        {
            if (i % 4 == 0)
            {
                sayilar = sayilar + "-" + i.ToString();
            }
        }
        return sayilar;
    }
    string BeseBolum (int sayi1, int sayi2)
    {
        if (sayi2 <= sayi1)
        {
            int gecici = sayi1;
            sayi1 = sayi2;
            sayi2 = gecici;

        }
        string sayilar = "";
        for (int i = sayi1; i <= sayi2; i++)
        {
            if (i % 5 == 0)
            {
                sayilar = sayilar + "-" + i.ToString();
            }
        }
        return sayilar;
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
