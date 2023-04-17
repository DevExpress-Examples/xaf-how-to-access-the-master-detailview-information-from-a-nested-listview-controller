using DevExpress.ExpressApp.Actions;

namespace GetMasterFrame.Module.Controllers {
    public class ContactController: MasterDetailViewController {
        public ContactController() {
            MyAction = new SimpleAction(this, "MySimpleAction", DevExpress.Persistent.Base.PredefinedCategory.Edit);
        }
        public SimpleAction MyAction { get; set; }
    }
}
