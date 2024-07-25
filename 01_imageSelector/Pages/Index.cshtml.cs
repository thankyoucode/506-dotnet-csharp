using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _01_imageSelector.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            // Initialize ImageOptions with actual data
            ImageOptions = new List<SelectListItem>
            {
                new SelectListItem { Value = "images/python.webp", Text = "Python" },
                new SelectListItem { Value = "images/C.png", Text = "C" },
                new SelectListItem { Value = "images/react.png", Text = "React" },
                new SelectListItem { Value = "images/angular.png", Text = "Angular" }
            };

            // Set a default selected image
            SelectedImage = ImageOptions[0].Value; // Default to the first image
        }

        // Property to hold the selected image path
        [BindProperty]
        public string SelectedImage { get; set; } = string.Empty; // Initialize with empty string

        // Property to provide options for the dropdown list
        public List<SelectListItem> ImageOptions { get; set; } = new List<SelectListItem>(); // Initialize with an empty list

        public void OnGet()
        {
            // No need to initialize here if already initialized in the constructor
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Read the entire form asynchronously
            var form = await Request.ReadFormAsync();

            // Retrieve the value of SelectedImage from the form data
            string? selectedImage = form["SelectedImage"];

            if (!string.IsNullOrEmpty(selectedImage))
            {
                SelectedImage = selectedImage;
            }
            else
            {
                // Handle case where form value "SelectedImage" is not found
                // You might choose to set a default value or handle it differently
                SelectedImage = ImageOptions[0].Value; // Default to the first image as a fallback
            }

            // Return the page to update the content without redirecting
            return Page();
        }
    }
}
