using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMasterFrame.Module.BusinessObjects;
[DefaultClassOptions]
public class MyTask : BaseObject {
    public virtual string Subject{get;set;}
    public virtual Contact AssignedTo{ get; set; }
}



