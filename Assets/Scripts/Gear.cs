using UnityEngine;

public class Gear : MonoBehaviour
{
	private Animator animator;

	public bool clockwise;

	public float speed;

	private void Start()
	{
		animator = GetComponent<Animator>();
	}

	private void Update()
	{
		animator.SetBool("Clockwise", clockwise);
		animator.speed = speed;
	}
}
