using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [Obsolete("CommentsRestService does not return data of this type.")]
    public class CommentsSettingsContract
    {
        public bool? ApproveComments { get; set; }
        public bool DisplayEmailField { get; set; }
        public bool DisplayMessageField { get; set; }
        public bool DisplayNameField { get; set; }
        public bool DisplayWebSiteField { get; set; }
        public bool HideCommentsAfterNumberOfDays { get; set; }
        public bool IsEmailFieldRequired { get; set; }
        public bool IsMessageFieldRequired { get; set; }
        public bool IsNameFieldRequired { get; set; }
        public bool IsWebSiteFieldRequired { get; set; }
        public int NumberOfDaysToHideComments { get; set; }
        public PostRights PostRights { get; set; }
        public bool UseSpamProtectionImage { get; set; }

        public CommentsSettingsContract() { }
    }
}
