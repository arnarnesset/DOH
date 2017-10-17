using System.ComponentModel.DataAnnotations;

namespace DOH.Helpers
{
    public class ResourcesDemo
    {
        [Display(Name = "ApplicationName", ResourceType = typeof(MyClassLibrary.Resources))]
        public string ApplicationName { get; set; }

        [Display(Name = "StreetName", ResourceType = typeof(MyClassLibrary.Resources))]
        [Required(AllowEmptyStrings = false,
            ErrorMessageResourceName = "StreetErrorMandatory",
            ErrorMessageResourceType = typeof(MyClassLibrary.Resources))]
        public string StreetName { get; set; }
    }
}