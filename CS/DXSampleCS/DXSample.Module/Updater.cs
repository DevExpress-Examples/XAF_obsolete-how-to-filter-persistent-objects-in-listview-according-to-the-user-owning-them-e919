using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.Persistent.BaseImpl;

namespace DXSample.Module {
    public class Updater : ModuleUpdater {
        public Updater(ObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            CreateUser("Sam", "", true);
            CreateUser("John", "", false);
            CreateUser("Paul", "", false);
        }
        private void CreateUser(string name, string password, bool isAdministrator) {
            BasicUser BasicUser = ObjectSpace.FindObject<BasicUser>(new BinaryOperator("UserName", name));
            if (BasicUser == null) {
                BasicUser = ObjectSpace.CreateObject<BasicUser>();
                BasicUser.UserName = name;
                BasicUser.FullName = name;
            }
            BasicUser.IsAdministrator = isAdministrator;
            BasicUser.SetPassword(password);
            BasicUser.Save();
        }
    }
}
