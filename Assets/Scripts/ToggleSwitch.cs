﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSwitch : Trigger {
	
	void Toggle () {
		activated = !activated;
	}

	void OnMouseDown () {
		Toggle ();
	}
}