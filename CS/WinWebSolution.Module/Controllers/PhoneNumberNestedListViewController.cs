using System;
using System.Reflection;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.BaseImpl;

namespace WinWebSolution.Module {
    public class PhoneNumberNestedListViewController : NestedListViewControllerBase {
        private SimpleAction saMasterDetailViewInfoAction = null;
        public PhoneNumberNestedListViewController() {
            TargetObjectType = typeof(PhoneNumber);
            saMasterDetailViewInfoAction = new SimpleAction(this, "MasterDetailViewInfoAction", DevExpress.Persistent.Base.PredefinedCategory.View);
            saMasterDetailViewInfoAction.Execute += new SimpleActionExecuteEventHandler(saMasterDetailViewInfoAction_Execute);
        }
        void saMasterDetailViewInfoAction_Execute(object sender, SimpleActionExecuteEventArgs e) {
            MasterDetailViewInfo();
        }
        private void MasterDetailViewInfo() {
            Console.WriteLine(string.Format("MasterViewId = '{0}'", this.MasterDetailViewId));
        }
        protected override void OnActivated() {
            base.OnActivated();
            View.ControlsCreated += new EventHandler(View_ControlsCreated);
        }
        void View_ControlsCreated(object sender, EventArgs e) {
            MasterDetailViewInfo();
        }
    }
}
