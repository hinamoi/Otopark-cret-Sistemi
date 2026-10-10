using UnityEngine;

public class OtoparkÜcretSistemi : MonoBehaviour
{
    void Start() //Sistemde yapılmasını istediğim işlemleri gerçekleştirmek için kullandım.
    {
        int otopark_saati = 1; //Otopark saatini belirlemek için tam sayı türünde "otopark_saati" değişkeni oluşturdum. 

switch (otopark_saati) //Otopark saati için farklı durumları değerlendirmek ve kontrol etmek için kullandım.
{
    case 1: //Switch içindeki saate karşılık gelen durumları belirlemek için kullandım. 1,2,3,4 ve 5 saat olmak üzere toplam 5 tane durum oluşturdum ve bu durumlara karşılık gelen ücretler belirledim.
        Debug.Log("Otopark ücreti: 120Tl"); //Otopark saatine göre yazılması gereken metni Console ekranına yazdırmak için kullandım.
            break; //Durum eşleştiğinde Switch yapısından çıkmak ve diğer Case'lerin (durumların) çalışmasını önlemek için kullandım.

    case 2:
        Debug.Log("Otopark ücreti: 200TL"); 
            break;

    case 3:
        Debug.Log("Otopark ücreti: 300TL");
            break;

    case 4:
        Debug.Log("Otopark ücreti: 400TL");
            break;

    case 5:
        Debug.Log("Otopark ücreti: 550TL");
            break;

    default: //Hiçbir Case koşulu gerçekleşmediğinde çalışacak işlem için kullandım.
                Debug.Log("Otoparkımız en fazla 5 saat süreye kadar kullanılabilmektedir. 5 saati aşan durumlar yasaktır ve bu kuralın ihlali sonucunda 1.500TL para cezası uygulanacaktır.");
            break;
}
    }
}