using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class loc_manager : MonoBehaviour 
{
	int INF=10000;
	private float currentLongitude;
	private float currentLatitude;
	//public Text tx;

	IEnumerator GetCoordinates()
	{
		//while true so this function keeps running once started.
		while (true) 
		{
			// check if user has location service enabled
			if (!Input.location.isEnabledByUser) {
				//tx.text = "Long:-" + currentLongitude + "Lat:" + currentLatitude + "Not enable";
				yield break;
			}

			// Start service before querying location
			Input.location.Start ();

			// Wait until service initializes
			int maxWait = 20;
			while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0) {
				yield return new WaitForSeconds (1);
				maxWait--;
			}

			// Service didn't initialize in 20 seconds
			if (maxWait < 1) 
			{
				print ("Timed out");//tx.text = "Time out";
				yield break; 
			}

			// Connection has failed
			if (Input.location.status == LocationServiceStatus.Failed) {
				print ("Unable to determine device location"); //tx.text = "Unable to determine device location";
				yield break;
			} 
			else
			{
				//overwrite current lat and lon everytime
				currentLatitude = Input.location.lastData.latitude;
				currentLongitude = Input.location.lastData.longitude;
			//	tx.text = "Long:-" + currentLongitude + "Lat:" + currentLatitude;
				if (!check_lie()) 
				{
					SceneManager.LoadSceneAsync( "Options");
				
				} 

			}
			Input.location.Stop();
		}
	}





	void Awake()
	{
		//start GetCoordinate() function 
		StartCoroutine ("GetCoordinates");
		//tx.GetComponent<Text> ();
	}





// Given three colinear points p, q, r, the function checks if
// point q lies on line segment 'pr'
bool onSegment(Point p, Point q, Point r)
{
		if (q.x <= Mathf.Max(p.x, r.x) && q.x >= Mathf.Min(p.x, r.x) &&
		q.y <= Mathf.Max(p.y, r.y) && q.y >= Mathf.Min(p.y, r.y))
		return true;
	return false;
}

// To find orientation of ordered triplet (p, q, r).
// The function returns following values
// 0 --> p, q and r are colinear
// 1 --> Clockwise
// 2 --> Counterclockwise
int orientation(Point p, Point q, Point r)
{
	float val = (q.y - p.y) * (r.x - q.x) -
		(q.x - p.x) * (r.y - q.y);

	if (val == 0f) return 0;  // colinear
	return (val > 0)? 1: 2; // clock or counterclock wise
}

// The function that returns true if line segment 'p1q1'
// and 'p2q2' intersect.
bool doIntersect(Point p1, Point q1, Point p2, Point q2)
{
	// Find the four orientations needed for general and
	// special cases
	float o1 = orientation(p1, q1, p2);
	float o2 = orientation(p1, q1, q2);
	float o3 = orientation(p2, q2, p1);
	float o4 = orientation(p2, q2, q1);

	// General case
	if (o1 != o2 && o3 != o4)
		return true;

	// Special Cases
	// p1, q1 and p2 are colinear and p2 lies on segment p1q1
	if (o1 == 0 && onSegment(p1, p2, q1)) return true;

	// p1, q1 and p2 are colinear and q2 lies on segment p1q1
	if (o2 == 0 && onSegment(p1, q2, q1)) return true;

	// p2, q2 and p1 are colinear and p1 lies on segment p2q2
	if (o3 == 0 && onSegment(p2, p1, q2)) return true;

	// p2, q2 and q1 are colinear and q1 lies on segment p2q2
	if (o4 == 0 && onSegment(p2, q1, q2)) return true;

	return false; // Doesn't fall in any of the above cases
}

// Returns true if the point p lies inside the polygon[] with n vertices
bool isInside(Point[] polygon, int n, Point p)
{
	// There must be at least 3 vertices in polygon[]
	if (n < 3)  return false;

	// Create a point for line segment from p to infinite
		Point extreme = new Point(INF, p.y);

	// Count intersections of the above line with sides of polygon
	int count = 0, i = 0;
	do
	{
		int next = (i+1)%n;

		// Check if the line segment from 'p' to 'extreme' intersects
		// with the line segment from 'polygon[i]' to 'polygon[next]'
		if (doIntersect(polygon[i], polygon[next], p, extreme))
		{
			// If the point 'p' is colinear with line segment 'i-next',
			// then check if it lies on segment. If it lies, return true,
			// otherwise false
			if (orientation(polygon[i], p, polygon[next]) == 0)
				return onSegment(polygon[i], p, polygon[next]);

			count++;
		}
		i = next;
	    } 
		while (i != 0);

	// Return true if count is odd, false otherwise
		if (count % 2 == 1) 
		{
			return true;
		} else
		{
			return false;
		}
}

// Driver program to test above functions
	public bool check_lie()
    {
		Point[] polygon1 = new Point[4];
		polygon1 [0] = new Point (74.87721f,31.62106f);
		polygon1 [1] = new Point (74.87685f, 31.62067f);
		polygon1 [2] = new Point (74.87721f,31.62106f);
		polygon1 [3] = new Point (74.87685f, 31.62067f);


		Point p = new Point(currentLongitude,currentLatitude);
        int n = polygon1.Length;
		if(isInside(polygon1, n, p)){return true;}else{return false;}
     }
}