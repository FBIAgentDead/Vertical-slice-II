using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour {

	CharacterStats cardInfo;


	void Update()
	{
		if(cardInfo.canAttack){
			DisplayCards();
		}
	}

	private void DisplayCards(){
		//here with help of the cardInfo.AvailableCards display the right cards
	}

}
