using System;
using System.Collections.Generic;
using System.Text;

namespace WinWebSolution.Module {
    public interface IMasterDetailViewInfo {
        string MasterDetailViewId { get; }
        void AssignMasterDetailViewId(string id);
    }
}
