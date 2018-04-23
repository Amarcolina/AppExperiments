﻿using Leap.Unity.UserContext;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leap.Unity.LeapPaint {

  public class Button_StringChannel : UIButton {

    [Header("Ucon String Channel Output")]
    public string dataToSend = "";
    public StringChannel pressOutputChannel = new StringChannel("tool/action");

    public override void OnUnpress() {
      pressOutputChannel.Set(dataToSend);
    }

  }

}
