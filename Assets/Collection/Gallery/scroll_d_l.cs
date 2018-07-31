using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scroll_d_l : MonoBehaviour {
	public Scrollbar scroll;
	public List<Image> image_list;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float mult = 0.043f;
		float temp = mult;
		if (Input.touchCount == 0) 
		{
			float scroll_val = scroll.GetComponent<Scrollbar> ().value;
			int index = 1;
			jugar2 (temp, mult, scroll_val,index);
		}
	}
	void jugar2(float temp,float mult,float scroll_val,int index)
	{
		if (scroll_val < 0.043f) {
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 0.043f, 0.1f);
			jugar (0);


		} 
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (1);
            
		} 
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (2);
			
		}
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (3);
			
		}
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (4);
			
		}
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (5);
			
		}
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (6);
			
		}
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (7);
			
		}
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (8);
			
		}
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (9);
			
		}
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (10);
			
		}
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (11);
			
		} 
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (12);
			
		}
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (13);
			
		}
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (14);
			
		}
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (15);
			
		}
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (16);
			
		}
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (17);
			
		}
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (18);
			
		}
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (19);
			
		}
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (20);
			
		}
		else if (scroll_val > temp && scroll_val < (temp=2*temp)) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (21);
			
		}
		else if (scroll_val > temp && scroll_val <= 2*temp) 
		{
			scroll.GetComponent<Scrollbar> ().value = Mathf.Lerp (scroll.GetComponent<Scrollbar> ().value, 2*temp, 0.1f);
			jugar (22);
			
		}
	}
	void jugar(int index)
	{
		for (int i = 0; i<=image_list.Capacity-1; i++) 
		{	
			image_list [i].transform.localScale = Vector2.Lerp (image_list [i].transform.localScale, new Vector2 (1, 1), 0.1f);
		}
		image_list [index].transform.localScale = Vector2.Lerp (image_list [index].transform.localScale, new Vector2 (1.2f, 1.2f), 0.1f);
	}

}
