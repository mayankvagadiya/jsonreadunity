using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class jsondataread : MonoBehaviour
{  
   //enter your json data file path from resource folder without extension (text file)
    public string filepath = "dataTest"; 
   
   // List to save json data
    private List<TeamClass> m_Team;
   
    void Start()
    {
		TextAsset textAsset = Resources.Load<TextAsset>(filepath);
		string data = textAsset.text;
		m_Team = JsonConvert.DeserializeObject<List<TeamClass>>(data);
		Debug.Log("TEXT=" + m_Team.Count);
    }
  
	public class TeamClass
	{
		[JsonProperty("Index")]
		private int m_ID;

		[JsonProperty("TeamName")]
		private string m_Name;

		[JsonProperty("Country")]
		private string m_Country;
  }
 }
