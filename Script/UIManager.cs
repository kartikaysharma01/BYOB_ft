using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {


	public GameObject menuPanel, ingamePanel, timeOutPanel, killedByPanel; 


	public void TimeOut()
	{
		menuPanel.SetActive (false);
		ingamePanel.SetActive (false);
		timeOutPanel.SetActive (true);
		killedByPanel.SetActive (false);
	}

	public void KilledBy()
	{
		menuPanel.SetActive (false);
		ingamePanel.SetActive (false);
		timeOutPanel.SetActive (false);
		killedByPanel.SetActive (true);
	}
}
