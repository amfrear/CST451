// ==============================================================================
// File: ChildDetails.cshtml.cs
// Description: Handles the logic for displaying the details of a single child, 
//              including their symptoms. Fetches child data by ID and returns 
//              a 404 error if the child is not found.
// Author: Alex Frear
// Created: July 21, 2025
// ==============================================================================

using MedicalJourneyLog.Data;
using MedicalJourneyLog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace MedicalJourneyLog.Pages
{
    // This PageModel handles the Child Details view.
    // It loads a child's profile and their symptoms based on a unique ID.
    public class ChildDetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        // This constructor brings in the database context
        // so we can query our database inside this page.
        public ChildDetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        // This is the property that holds the specific child we want to display.
        // I initialize it with a new Child object to prevent any null errors.
        public Child Child { get; set; } = new();

        // This method runs when the page is accessed.
        // It looks up the child by ID and includes their symptoms using EF Core’s eager loading.
        public async Task<IActionResult> OnGetAsync(int id)
        {
            // Here, we query the database for a child with the matching ID
            // and also include their symptom history in the same query.
            Child = await _context.Children
                .Include(c => c.Symptoms)
                .FirstOrDefaultAsync(c => c.Id == id);

            // If no child is found, we return a 404 Not Found response.
            if (Child == null)
            {
                return NotFound();
            }

            // Otherwise, we return the page, and the Razor view will take care of displaying the data.
            return Page();
        }
    }
}
