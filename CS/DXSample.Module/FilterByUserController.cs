
using DevExpress.ExpressApp;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Data.Filtering;

namespace DXSample.Module {
    public partial class FilterByUserController : ViewController {
        public FilterByUserController() {
            InitializeComponent();
            RegisterActions(components);
            TargetViewType = ViewType.ListView;
            TargetObjectType = typeof(IOwnedObject);
        }
        protected override void OnActivated() {
            base.OnActivated();
            if (!((BasicUser)SecuritySystem.CurrentUser).IsAdministrator) {
                ((ListView)View).CollectionSource.Criteria["ByUser"] = CriteriaOperator.Parse("OwnerID = ?", SecuritySystem.CurrentUserId);
            }
        }
    }
}
