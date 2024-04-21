namespace UIFramework {
    /// <summary>
    /// Base class for panels that need no special Properties
    /// </summary>
    public abstract class PanelController : APanelController<PanelProperties> { }

    /// <summary>
    /// Base class for Panels
    /// </summary>
    public abstract class APanelController<T> : UIViewController<T>, IPanelController where T : IPanelProperties {
        public PanelPriority Priority {
            get {
                if (Properties != null) {
                    return Properties.Priority;
                }
                else {
                    return PanelPriority.None;
                }
            }
        }

        protected sealed override void SetProperties(T props) {
            base.SetProperties(props);
        }
    }
}
