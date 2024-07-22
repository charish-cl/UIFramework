using Utils;

namespace UIFramework.Examples
{
    public class StartDemoSignal : ASignal { }

    public class StartWindowController : WindowController
    {
        //由按钮绑定事件
        public void UI_Start() {
            Signals.Get<StartDemoSignal>().Dispatch();
        }
    }
}
