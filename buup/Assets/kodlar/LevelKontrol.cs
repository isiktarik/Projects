using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
using System; 
using GoogleMobileAds.Api;

public class LevelKontrol : MonoBehaviour {


    
	
	public Text Leveltxt;  
	public Text HataTxt;   
	
	public int ToplamLevel; // Kullanıcı en fazla kaç bölüm olduğunu yazmalı.!
	public static int ToplamLevelDegeri;  // Diğer scriptten toplam level değerine ulaşabilmek için yazdık.
	public static int suankiLevel;  // Şuan kaçıncı levelde olduğunu bildiren değişkenimiz.

	public RawImage[] LevelRawImageleri;  // Bölüm simgelerini yani Raw İmagelerini bu diziye atadık.
	public Texture[] LevelResmi;  // Bölümlerin açık olduğunda gösterilecek resimler.
	public Texture KilitResmi;  // Bölümler kapalı olduğunda gösterilecek resim.
	private InterstitialAd reklamObjesi;
	// NOT: LevelRawImageleri dizisi ile LevelResmi dizisi eşit olmalı.!!

	void Start () { 
		ToplamLevelDegeri = ToplamLevel; // Her Bölümden sonra menüye döndüğünü hesap ederek yola çıktık.
	}
	
	void Update () {
		suankiLevel = PlayerPrefs.GetInt ("Level");  // Şuanki level değerini çekiyoruz.
		Leveltxt.text ="Level"+suankiLevel.ToString(); // Çektiğimiz level değerini göstertiyoruz.

		if (suankiLevel == 0)  // Eğer şuanki level değerimiz 0 ise yani hiç kayıt olmadıysa ,
		{
			PlayerPrefs.SetInt ("Level", 1); // Level değerini 1 olarak kaydediyoruz.

			for (int i=0; i<=LevelRawImageleri.LongLength-1; i++)  
			{ 
				LevelRawImageleri [i].texture = KilitResmi; // Döngü ve dizileri kullanarak açık olmayan bölümlere kilit resmi koyduk.									
			}
		} else   // Eğer level değerimiz 0 dan farklı bir değer ise yani önceden kayıt var ise,
		{
			
			for (int y=0; y<=suankiLevel-1; y++) // Şuanki levelin 1 eksiği kadar döngü başlatıyoruz.
			{
				if (suankiLevel > ToplamLevel) // Eğer suanki level Toplam levelimizden yüksek ise,
				{
					Leveltxt.text = "Complete!"; // LevelTxt de oyunun bittiğini bildiriyoruz.
					for (int z=0; z<=LevelRawImageleri.LongLength-1; z++)  
						// Dizi indeksi ile bölüm indeksini karıştırmamak için 1 eksiği ile döngü başlattık.
					{ 
						LevelRawImageleri [z].texture =  LevelResmi [z]; // Eğer oyun bittiyse tüm bölümlere açık resmi koyuyoruz.					
					}
				}
				else // Eğer suanki level Toplam levelimizden yüksek DEĞiLSE,
				{
				LevelRawImageleri [y].texture = LevelResmi [y]; // Geçtiğimiz bölümlere açık olan resmi getiriyoruz.
				}
			}
			
		}

	}
	
	public void LevelGonder(string Level) // Raw İmagelerin Pointer Click eventine bu methodu veriyoruz.
	{									  // String değeri olarakta hangi levele gitmek istediğini yazıyoruz.

		if (suankiLevel >= Convert.ToInt32(Level)) //String değerini int değerine çevirerek şuanki levele eşit yada büyükmü diye bakıyoruz ?
		{
			

			Application.LoadLevel ("Level" + Level);

		}

		 //Eğer büyük yada eşitse Levele Gönderiyoruz.

	else 
		{
			HataTxt.text ="Locked"; // Eğer değilse bunu HataTxt inde belirtiyoruz.Şuanki level 2 iken 5.levele girmesini istemeyiz :)
		}
	}

	public void Temizle() // Sıfırla butonunun click olayına bu methodu giriyoruz.
	{
		PlayerPrefs.DeleteAll (); // Tüm PlayerPrefs değerlerini siler.
	}
	public void LevelSifirla()
	{
		PlayerPrefs.DeleteAll ();
	}

}
