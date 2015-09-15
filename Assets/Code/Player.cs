using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    private int m_score = 0;
	private float m_speed = 5;
	private float m_rotate = 0f;
    // Update is called once per frame
    void Update()
    {
        //beweeg de speler naar rechts
        this.transform.position += Vector3.right * Time.deltaTime* m_speed;
		this.transform.Rotate(0.0f, 0.0f, m_rotate*-1);
		Debug.Log (m_score);
    }

	public int Addscore
	{
		get {return m_score; }
		set {m_score += value; }
	}   

	public float Slow
	{
		get {return m_speed; }
		set {m_speed = value; }
	}   

	public float Rotate
	{
		get {return m_rotate; }
		set {m_rotate = value; }
	}
}
