using DevExpress.ExpressApp;

namespace GetMasterFrame.Module.Controllers {
    public class NestedListViewFrameController : ViewController {
        protected Frame masterFrame;
        public NestedListViewFrameController() {
            TargetViewType = ViewType.ListView;
            TargetViewNesting = Nesting.Nested;
        }
        public void AssignMasterFrame(Frame parentFrame) {
            masterFrame = parentFrame;
            // Use this Frame to get Controllers and Actions. 
        }
    }
}
