﻿using Leap.Unity;
using Leap.Unity.RuntimeGizmos;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leap.Unity.LeapPaint {

  public class RightHandFistStrengthBarGizmo : MonoBehaviour {

    public Color color;

    float _fistStrength = 0f;

    void Update() {
      var hand = Hands.Right;

      if (hand != null) {
        _fistStrength = hand.GetFistStrength();
      }

      BarGizmo.Render(_fistStrength, this.transform, color, 0.25f);
    }

  }

}