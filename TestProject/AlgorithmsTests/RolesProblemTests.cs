
using PracticeConsoleApp.Algorithms;

namespace TestProject.AlgorithmsTests
{
    public class RolesProblemTests
    {
        private Authorization GetAuth()
        {
            var permissions = new List<Permission>
        {
            new Permission("admin", "View Orders", true),
            new Permission("admin", "Block User Account", true),
            new Permission("admin", "Purchased Widgets", false),
            new Permission("support", "Refund", true),
            new Permission("support", "View Orders", true),
            new Permission("guest", "Browse", true),
        };

            var users = new List<User>
        {
            new User(1, "John", new List<string>{ "admin" }),
            new User(2, "Sarah", new List<string>{ "support","guest" }),
            new User(3, "Mike", new List<string>()),  // no roles
            new User(4, "Rick", null),                // null roles
            new User(5, "Jane", new List<string>{ "admin","admin" }) // duplicate roles
        };

            return new Authorization(permissions, users);
        }

        [Fact]
        public void ListPermissions_ReturnsActivePermissions()
        {
            var auth = GetAuth();
            var result = auth.ListPermissions(1);

            Assert.Contains("View Orders", result);
            Assert.Contains("Block User Account", result);
            Assert.DoesNotContain("Purchased Widgets", result);
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void ListPermissions_MergesPermissionsAcrossRoles()
        {
            var auth = GetAuth();
            var result = auth.ListPermissions(2);

            Assert.Contains("Refund", result);
            Assert.Contains("Browse", result);
            Assert.Contains("View Orders", result);
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void CaseInsensitiveCheck_ShouldBeTrue()
        {
            var auth = GetAuth();
            Assert.True(auth.CheckPermitted("view orders", 1));
        }

        [Fact]
        public void ListPermissions_WhenNoRoles_ReturnsEmpty()
        {
            var auth = GetAuth();
            Assert.Empty(auth.ListPermissions(3));
        }

        [Fact]
        public void DuplicateRolePermissions_ShouldNotRepeat()
        {
            var auth = GetAuth();
            var result = auth.ListPermissions(5);

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void CheckPermitted_ReturnsTrueIfActive()
        {
            var auth = GetAuth();
            Assert.True(auth.CheckPermitted("Refund", 2));
        }

        [Fact]
        public void CheckPermitted_ReturnsFalseIfInactive()
        {
            var auth = GetAuth();
            Assert.False(auth.CheckPermitted("Purchased Widgets", 1));
        }

        [Fact]
        public void ListPermissions_ReturnsEmpty_WhenUserNotFound()
        {
            var auth = GetAuth();
            Assert.Empty(auth.ListPermissions(999));   // SAFER BEHAVIOR
        }
    }
}
