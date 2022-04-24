using UnityEngine;

public class Human : MonoBehaviour
{
    [SerializeField] string firstname="No Name";
    [SerializeField] string familyname = "No Name";
    [SerializeField, Min(1900)] int born = 1950;
    [SerializeField, Range(50, 300)] float height = 160;
    [SerializeField] bool isAlive = true;

    [Space]
    [SerializeField] bool blabbla;
    [SerializeField] bool krixkrax;

    // BLABLA
    // �lnie kell
    // Magasabb 165 cm-n�l, de kisebb 200-n�l
    // 2000 vagy azut�n sz�letetteket vesz�nk fel

    // KIRXKRAX
    // Kisebb 180 cm-n�l vagy nagyobb 210-n�l
    // Azonnal felvessz�k, ha a keresztneve �s a vezet�kneve megegyezik

    void OnValidate()
    {
        blabbla = isAlive && (height > 165 && height < 200) && (born >= 2000);
        krixkrax = (height > 210 || height < 180) || (firstname==familyname);
    }
}
