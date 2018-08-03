using System;
using System.Reflection;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;

namespace WinWebSolution.Module {
    public abstract class NestedListViewControllerBase : ViewController, IMasterDetailViewInfo {
        public NestedListViewControllerBase() {
            TargetViewNesting = Nesting.Nested;
            TargetViewType = ViewType.ListView;
        }
        protected override void OnActivated() {
            base.OnActivated();
        }
        private string masterDetailViewIdCore = String.Empty;
        #region IMasterDetailViewInfo Members
        public string MasterDetailViewId {
            get { return masterDetailViewIdCore; }
        }
        public void AssignMasterDetailViewId(string id) {
            masterDetailViewIdCore = id;
        }
        #endregion
    }
}
