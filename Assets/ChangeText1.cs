using UnityEngine;
using UnityEngine.UI;

public class ButtonTextChanger : MonoBehaviour
{
    public Text textDisplay;
    public string[] textOptions;

    private int currentIndex = 0;

    void Start()
    {
        textOptions = new string[] { "dobri moj dragi saradnici danas cu da vas ucim o osnovama jave",
                                    "kao prvo morate da znate o varijablama",
                                    "postoje int, double, char, boolean i string",
                                    "int je za ceo broj, double je za broj sa decimalom, char za karakter",
                                    "boolean je za true i false, i string je za vise karaktera",
                                    "postoje i operatori +, -, / i * koje imaju istu ulogu kao i u matematici",
                                    "takodje postoji i  % sto vraca ostatak tokom deljenja",
                                    "na primer 567%10=7",
                                    "postoje i operator if i switch",
                                    "if je naredba ako tako da ako stavis if(1>3){ovde ide kod} izvrsice se funkcija",
                                    "takodje mozes da koristis else{kod}",
                                    "a switch je samo vise if-ova",
                                    "primer za switch: switch(varijabla){case 1: promenljiva=1; break; case 2: promenljiva=2; break;}",
                                    "break se koristi da bi switch zavrsio kada se izvrsi case",
                                    "postoje i petlje, a to su while i for",
                                    "while() se izvrsava sve dok je operacija tacna u zagradi",
                                    "na primer while(1==1) izvrsava ce se beskonacno",
                                    "a for je isto to samo dodaje int i funkciju",
                                    "na primer for(int i=1;prom>i;i++) izvrsavace se sve dok je prom veci od i, a i sve vreme raste",
                                    "i za kraj imas System.out.println() koji ispisuje sta mu zadate",
                                    "ako oces da ispises neku rec ili recenicu stavis navodnike",
                                    "ali ako hoces da ispises varijablu samo stavis ime varijable bez navodnika",
                                    "to je to za ovo predavanje ako hocete opet da prodjete kroz sve kliknite dugme dalje, a ako ste zavrsli kliknite dugme na p*sao" };

        if (textDisplay != null && textOptions.Length > 0)
        {
            textDisplay.text = textOptions[currentIndex];
        }
    }

    public void ChangeText()
    {
        if (textOptions.Length == 0 || textDisplay == null) return;

        currentIndex = (currentIndex + 1) % textOptions.Length;
        textDisplay.text = textOptions[currentIndex];
    }
}