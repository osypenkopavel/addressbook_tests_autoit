using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class DeleteGroupTests : TestBase
    {
        [Test]
        public void TestDeleteGroup()
        {
            GroupData newGroup = new GroupData()
            {
                Name = "Test"
            };

            app.Groups.CreateGroupIfAbsent(newGroup);

            List<GroupData> oldGroups = app.Groups.GetGroupList();            
            
            app.Groups.Remove(0);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
