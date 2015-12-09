using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ParkManager : MonoBehaviour {
	
	[HeaderAttribute("Status")]
	public float time;
	public int month;
	public float progression;
	[HeaderAttribute("Setup")]
	public Tile tilePrefab;
	public Trash trashPrefab;
	
	[HeaderAttribute("Balance")]
	public float timePerMonth;
	 
	
	[HeaderAttribute("UI")]
	public Text uiTextOutput;
	
	private List<Tile> tiles;
	private List<Trash> trash;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
