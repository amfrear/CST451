// ==============================================================================
// File: Symptom.cs
// Description: Represents a symptom logged for a child, including the name, 
//              optional description, and the date it was recorded.
// Author: Alex Frear
// Created: July 21, 2025
// ==============================================================================

namespace MedicalJourneyLog.Models
{
    /// <summary>
    /// Represents a symptom experienced by a child, logged by a caregiver.
    /// </summary>
    public class Symptom
    {
        /// <summary>
        /// Primary key identifier for the symptom entry.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name or short label for the symptom (e.g., "Fever", "Cough").
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Optional description providing more detail about the symptom.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// The date and time the symptom was logged.
        /// Defaults to the current time.
        /// </summary>
        public DateTime DateLogged { get; set; } = DateTime.Now;

        /// <summary>
        /// Foreign key referencing the associated child.
        /// </summary>
        public int ChildId { get; set; }

        /// <summary>
        /// Navigation property for the related child.
        /// </summary>
        public Child? Child { get; set; }
    }
}
