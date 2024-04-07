﻿using deVoid.Utils;

namespace UIFramework.Examples
{
    public class StartDemoSignal : ASignal { }

    public class StartWindowController : AWindowController
    {
        public void UI_Start() {
            Signals.Get<StartDemoSignal>().Dispatch();
        }
    }
}
