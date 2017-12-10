using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kursun : MonoBehaviour {
    public Rigidbody my_rb;
    public float force_min;
    public float force_max;
    float lifetime = 4;
    float fadetime = 2;
	// Use this for initialization
	void Start () {
        float force = Random.Range(force_min, force_max);
        my_rb.AddForce(transform.right * force);
        my_rb.AddTorque(Random.insideUnitSphere * force);
        StartCoroutine(Fade());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator Fade() {
        yield return new WaitForSeconds(lifetime);
        float percent = 0;
        float fade_speed = 1 / fadetime;
        Material mat = GetComponent<Renderer>().material;
        Color initialcolour = mat.color;
        while (percent < 1) {
            percent += Time.deltaTime * fade_speed;
            mat.color = Color.Lerp(initialcolour, Color.clear, percent);
            yield return null;    
        }
        Destroy(gameObject);
            }
}
