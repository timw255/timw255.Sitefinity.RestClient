using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfMembershipUser : WcfItemBase, IEquatable<WcfMembershipUser>
    {
        public bool AvatarImageSmallerWidth { get; set; }
        public string AvatarImageUrl { get; set; }
        public string AvatarThumbnailUrl { get; set; }
        public string Comment { get; set; }
        public DateTime CreationDate { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public bool IsApproved { get; set; }
        public bool IsBackendUser { get; set; }
        public bool IsLockedOut { get; set; }
        public bool IsLoggedIn { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public DateTime? LastLockoutDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? LastPasswordChangedDate { get; set; }
        public string Password { get; set; }
        public string PasswordAnswer { get; set; }
        public string PasswordQuestion { get; set; }
        public string ProfileData { get; set; }
        public string ProviderName { get; set; }
        public object ProviderUserKey { get; set; }
        public string RoleNamesOfUser { get; set; }
        public RoleProviderPair[] RolesOfUser { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }

        public WcfMembershipUser() { }

        public bool Equals(WcfMembershipUser other)
        {
            if (other == null || !(this.UserID == other.UserID))
            {
                return false;
            }
            return this.ProviderName == other.ProviderName;
        }
    }
}
