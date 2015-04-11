using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [Obsolete("Comment status is a string. Some predefined values are located in Telerik.Sitefinity.Services.Comments.StatusConstants.")]
    public enum CommentStatus
    {
        Published,
        Hidden,
        Spam,
        WaitingForApproval
    }
}
