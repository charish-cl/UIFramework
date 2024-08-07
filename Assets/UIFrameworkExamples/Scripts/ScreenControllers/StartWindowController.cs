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

        public override void UI_Close()
        {
            base.UI_Close();
        }

        protected override void AddListeners()
        {
            base.AddListeners();
        }

        protected override void OnPropertiesSet()
        {
            base.OnPropertiesSet();
        }
    }
}
