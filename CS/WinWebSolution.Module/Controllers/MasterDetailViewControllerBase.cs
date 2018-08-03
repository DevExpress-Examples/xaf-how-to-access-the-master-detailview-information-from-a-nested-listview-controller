using System;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Editors;

namespace WinWebSolution.Module {
    public class MasterDetailViewControllerBase : ViewController {
        public MasterDetailViewControllerBase() {
            TargetViewType = ViewType.DetailView;
            TargetViewNesting = Nesting.Root;
        }
        protected override void OnActivated() {
            base.OnActivated();
            foreach (ListPropertyEditor lpe in ((DetailView)View).GetItems<ListPropertyEditor>()) {
                if (lpe.Frame != null) {
                    CustomizeMasterDetailViewInfo(lpe.Frame);
                }
                else {
                    lpe.ControlCreated += new EventHandler<EventArgs>(lpe_ControlCreated);
                }
            }
        }
        void lpe_ControlCreated(object sender, EventArgs e) {
            CustomizeMasterDetailViewInfo(((ListPropertyEditor)sender).Frame);
        }
        private void CustomizeMasterDetailViewInfo(Frame frame) {
            foreach (Controller c in frame.Controllers) {
                if (c is IMasterDetailViewInfo) {
                    ((IMasterDetailViewInfo)c).AssignMasterDetailViewId(View.Id);
                }
            }
        }
    }
}