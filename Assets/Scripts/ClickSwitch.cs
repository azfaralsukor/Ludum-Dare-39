﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSwitch : Trigger {

	void Click () {
		if (working) {
			activated = true;
		}
	}

	void OnMouseDown () {
		Click ();
	}
}
