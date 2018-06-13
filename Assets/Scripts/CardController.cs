using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AssemblyCSharp.Assets.Scripts;

public class CardController : MonoBehaviour {

    private Suits suit;
    private Values value;
    private bool played;

	// Use this for initialization
    void Start () {
		played = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public Suits getSuit(){return this.suit;}

	public Values getValue(){return this.value;}
}
