using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType {HealthBuf, DamageBuf, ManaBuf, Shield, LASTINT}
public class Card{
	
    private float enumCount = (int)CardType.LASTINT;
	public int GetHealthBuf {get; set;}
	public int GetDamageBuf {get; set;}
	public int GetManaBuf {get; set;}
	public int GetPrice {get; set;}
	public CardType GetCardType {get; set;}

	public Card(){
		// RandomizeCard();
		Generate();
	}

	public virtual void Generate(){
		
	}

	// private void RandomizeCard(){
	// 	int i = Random.Range(0,Mathf.RoundToInt(enumCount));
	// 	// Debug.Log(i);
	// 	switch(i){
	// 		case 0:
	// 		GetCardType = CardType.HealthBuf;
	// 		GetHealthBuf = GenerateCardValue();
	// 		break;
	// 		case 1:
    //         GetCardType = CardType.DamageBuf;
	// 		GetDamageBuf = GenerateCardValue();
	// 		break;
    //         case 2:
    //         GetCardType = CardType.ManaBuf;
	// 		GetManaBuf = GenerateCardValue();
    //         break;
	// 		case 3:
	// 		//wat doen we hier?
	// 		GetCardType = CardType.Shield;
	// 		break;
	// 	}
	// }

	// private int GenerateCardValue(){
	// 	int buf = Random.Range(20, 100);
	// 	GetPrice = buf/2;
	// 	return buf;
	// }

}
