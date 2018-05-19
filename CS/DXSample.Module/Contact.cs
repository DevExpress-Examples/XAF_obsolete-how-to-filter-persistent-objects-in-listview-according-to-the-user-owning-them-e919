
using DevExpress.Xpo;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace DXSample.Module {
    [DefaultClassOptions]
    public class Contact : Person, IOwnedObject {
        public Contact(Session session) : base(session) { }

        private int _OwnerID;
        [MemberDesignTimeVisibility(false)]
        public int OwnerID {
            get { return _OwnerID; }
            set { SetPropertyValue("OwnerID", ref _OwnerID, value); }
        }

        public override void AfterConstruction() {
            base.AfterConstruction();
            OwnerID = (int)SecuritySystem.CurrentUserId;
        }
    }
}
