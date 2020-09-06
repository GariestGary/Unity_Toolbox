<<<<<<< Updated upstream
using UnityEngine;

[CreateAssetMenu(menuName = "Develop/Console Commands/Log Command")]
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Toolbox/Commands/Log Command", fileName = "Log Command")]
>>>>>>> Stashed changes
public class LogCommand : DefaultCommand
{
	public override bool Process(string[] args)
	{
		Debug.Log(string.Join(" ", args));
		return true;
	}
<<<<<<< Updated upstream
}
=======
}
>>>>>>> Stashed changes
