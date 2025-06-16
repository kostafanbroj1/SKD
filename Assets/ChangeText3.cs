using UnityEngine;
using UnityEngine.UI;

public class ButtonTextChanger3 : MonoBehaviour
{
    public Text textDisplay3;
    public string[] textOptions3;

    private int currentIndex3 = 0;

    void Start()
    {
        textOptions3 = new string[] { "dobro dosli na moje poslednje predavanje",
                                    "danas vas ucim o nizovima i matricama",
                                    "niz se obelezava sa '[]'",
                                    "recimo ako hocemo da napravimo int niz napisacemo 'int[] a'",
                                    "a ako hocemo da deklarismo koristimo {}",
                                    "na primer int[] a={1,2,3,4,5}",
                                    "ako hocemo da ispisemo neki specifican broj korisimo []",
                                    "na primer b=a[2], to ce uzeti treci broj u nizu jer niz pocinje od nula",
                                    "to je to od mene ako zelite da prodjete jos jednom kroz ovo kliknite dalje, a ako ste spremni klikni te na p*sao",};

        if (textDisplay3 != null && textOptions3.Length > 0)
        {
            textDisplay3.text = textOptions3[currentIndex3];
        }
    }

    public void ChangeText2()
    {
        if (textOptions3.Length == 0 || textDisplay3 == null) return;

        currentIndex3 = (currentIndex3 + 1) % textOptions3.Length;
        textDisplay3.text = textOptions3[currentIndex3];
    }
}