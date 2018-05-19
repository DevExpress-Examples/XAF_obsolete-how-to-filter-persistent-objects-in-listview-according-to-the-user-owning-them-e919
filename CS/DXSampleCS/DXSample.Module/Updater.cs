using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

namespace DXSample.Module {
    public class Updater : ModuleUpdater {
        public Updater(Session session, Version currentDBVersion) : base(session, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            CreateUser("Sam", "", true);
            CreateUser("John", "", false);
            CreateUser("Paul", "", false);
        }
        private void CreateUser(string name, string password, bool isAdministrator) {
            BasicUser BasicUser = Session.FindObject<BasicUser>(new BinaryOperator("UserName", name));
            if (BasicUser == null) {
                BasicUser = new BasicUser(Session);
                BasicUser.UserName = name;
                BasicUser.FullName = name;
            }
            BasicUser.IsAdministrator = isAdministrator;
            BasicUser.SetPassword(password);
            BasicUser.Save();
        }
    }
}
