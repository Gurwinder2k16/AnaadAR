using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
//------------------------------xml Structure
[XmlRoot("SachKhand")]
public class Player
{
	[XmlElement]
	public string User_Name { get; set; }

	[XmlElement]
	public string Email_id { get; set; }
}
//------------Implementation----------
	public class local_ctrl:MonoBehaviour
	{
		
    	public string get_email()
		{   Player head = Load ("sys.xml");
			return head.Email_id;
		}
		public string get_player_name()
		{  
			Player head = Load ("sys.xml");
			return head.User_Name;
		}
	//-------------------xml zone start
	public void Save(string path,string name,string email)
	{
		var serializer = new XmlSerializer(typeof(Player));
		using(var stream = new FileStream(Application.persistentDataPath +"/Data"+path, FileMode.Create))
		{
			serializer.Serialize(stream, new Player{User_Name=name,Email_id=email});
		}
	}
        public static Player Load(string path)
		{
			var serializer = new XmlSerializer(typeof(Player));
			//TextAsset tasset = Resources.Load ("sys.xml");
			using(var stream = new FileStream( Application.persistentDataPath +"/Data"+path, FileMode.Open))
			{
				return serializer.Deserialize(stream) as Player;
			}
		}

		//Loads the xml directly from the given string. Useful in combination with www.text.
		public static Player LoadFromText(string text) 
		{
			var serializer = new XmlSerializer(typeof(Player));
			return serializer.Deserialize(new StringReader(text)) as Player;
		}
	}


