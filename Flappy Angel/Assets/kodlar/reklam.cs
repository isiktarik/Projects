using UnityEngine;
using System.Collections;
using System;
using GoogleMobileAds.Api;

public class reklam : MonoBehaviour
{
	private InterstitialAd reklamObjesi;

	void Start()
	{
		YeniReklamAl( null, null );
		StartCoroutine( ReklamiGoster() );
	}
	IEnumerator ReklamiGoster()
	{
		while( !reklamObjesi.IsLoaded() )
			yield return null;

		reklamObjesi.Show();
	}

	public void YeniReklamAl( object sender, EventArgs args )
	{
		if( reklamObjesi != null )
			reklamObjesi.Destroy();

		reklamObjesi = new InterstitialAd( "ca-app-pub-7132433155859639/1388031506" );
		reklamObjesi.OnAdClosed += YeniReklamAl;
		AdRequest reklamiAl = new AdRequest.Builder()
			.AddTestDevice(AdRequest.TestDeviceSimulator)
			.AddTestDevice("8748E2446D6E93C19A9EDD708F88F3EA")
			.Build();
		reklamObjesi.LoadAd( reklamiAl );
	}
}