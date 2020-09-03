using UnityEngine;

[CreateAssetMenu(menuName = "Develop/Console Commands/Log Command")]
public class LogCommand : DefaultCommand
{
	public override bool Process(string[] args)
	{
		Debug.Log(string.Join(" ", args));
		return true;
	}
}