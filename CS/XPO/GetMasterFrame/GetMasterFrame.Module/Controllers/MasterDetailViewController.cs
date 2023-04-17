using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMasterFrame.Module.Controllers {


    public class MasterDetailViewController : ViewController<DetailView> {
        private void PushFrameToNestedController(Frame frame) {
            foreach (Controller c in frame.Controllers) {
                if (c is NestedListViewFrameController) {
                    ((NestedListViewFrameController)c).AssignMasterFrame(Frame);
                }
            }
        }
        private void lpe_FrameChanged(object sender, EventArgs e) {
            PushFrameToNestedController(((ListPropertyEditor)sender).Frame);
        }
        protected override void OnActivated() {
            base.OnActivated();
            foreach (ListPropertyEditor lpe in View.GetItems<ListPropertyEditor>()) {
                if (lpe.Frame != null) {
                    PushFrameToNestedController(lpe.Frame);
                } else {
                    lpe.FrameChanged += lpe_FrameChanged;
                }
            }
        }
        protected override void OnDeactivated() {
            foreach (ListPropertyEditor lpe in View.GetItems<ListPropertyEditor>()) {
                lpe.FrameChanged -= new EventHandler<EventArgs>(lpe_FrameChanged);
            }
            base.OnDeactivated();
        }
    }
}
