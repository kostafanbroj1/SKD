using UnityEngine;
using UnityEngine.UI;

public class ButtonTextChanger2 : MonoBehaviour
{
    public Text textDisplay2;
    public string[] textOptions2;

    private int currentIndex2 = 0;

    void Start()
    {
        textOptions2 = new string[] { "dobro dosli nazad u moj kombi",
                                    "danas vas ucim o metodama i osnovnim ugradjenim funkcijama",
                                    "metode se koriste da bi mogli da ponavljamo kod bez da moramo iznova da ga pisemo",
                                    "takodje je i lepse za pisajne i citanje",
                                    "metode se pisu van main metode ali u istoj klasi",
                                    "pre metode uglavnom stavljamo 'public static' pa varijabla ko ja nam treba i na kraju ime",
                                    "na primer ako nam treba metoda za sabiranje napisacemo - public static int sabiranje()",
                                    "u normalnoj zagradi mozemo da stavimo promenjljivu koju pozivamo iz druge metode",
                                    "na primer ako zelimo a i b iz druge metode napisacemo 'public static int sabiranje(int a,int b)'",
                                    "kada zavrsimo sa kodom u metodi na kraju napisemo 'return' i onda varijabla koja je ista varijabla kao i metoda",
                                    "sada na ugradjene funkcije",
                                    "ugradjene funkcije su jednostavnije",
                                    "tri osnovne su Math.abs, Math.sqrt i Math.random",
                                    "Math.abs se koristi za absolutnu vrednost",
                                    "Math.sqrt se korist da bi se nasao koren broja",
                                    "i Math.random se koristi da bi se napravio rendom broj od 0 do 1",
                                    "na primer moze da vrati 0.5342367",
                                    "to je to za ovo predavanje nadam se da je sve jasno",
                                    "klikni dalje da opet prodjes kroz predavanje, a na p*sao da bi ste otisli na posao"};

        if (textDisplay2 != null && textOptions2.Length > 0)
        {
            textDisplay2.text = textOptions2[currentIndex2];
        }
    }

    public void ChangeText2()
    {
        if (textOptions2.Length == 0 || textDisplay2 == null) return;

        currentIndex2 = (currentIndex2 + 1) % textOptions2.Length;
        textDisplay2.text = textOptions2[currentIndex2];
    }
}