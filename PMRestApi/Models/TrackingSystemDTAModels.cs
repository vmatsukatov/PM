using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PMRestApi.Models
{
    internal class ReleaseBindingModel
    {
        [Required]
        public string Key { get; internal set; }
        [Required]
        public string ProjectKey { get; internal set; }
        [Required]
        public bool IsActive { get; internal set; }

    }

    internal class IssueBindingModel
    {
        [Required]
        public string Key { get; internal set; }
        [Required]
        public string ProjectKey { get; internal set; }
        [Required]
        public IssueStatusEnum Status { get; internal set; }
        public TSUser AssignedUser { get; internal set; }

    }

    public class TSUser
    {
        [Required]
        public string Key { get; internal set; }
        [Required]
        public string Email { get; internal set; }
        [Required]
        public string FullName { get; internal set; }
        public string AvatarURL { get; internal set; }
    }
}