using DevExpress.ExpressApp;
using dxTestSolution.Module.BusinessObjects;

namespace GetMasterFrame.Module.Controllers {
    public class MyTaskController : NestedListViewFrameController {
        public MyTaskController() {
            TargetObjectType = typeof(MyTask);
        }
        private void UpdateMasterFrameAction() {
            var masterController = masterFrame.GetController<ContactController>();
            if (masterController != null) {
                masterController.MyAction.Caption = View.CurrentObject != null ? ((MyTask)View.CurrentObject).Subject : "Empty";
            }
        }
        private void View_CurrentObjectChanged(object sender, EventArgs e) {
            UpdateMasterFrameAction();
        }
        protected override void OnActivated() {
            base.OnActivated();
            View.CurrentObjectChanged += View_CurrentObjectChanged;
            UpdateMasterFrameAction();
        }
        protected override void OnDeactivated() {
            base.OnDeactivated();
            View.CurrentObjectChanged -= new EventHandler(View_CurrentObjectChanged);
        }

    }
}
