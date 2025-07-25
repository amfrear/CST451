// ==============================================================================
// File: Child.cs
// Description: Represents a child in the Medical Journey Log application. A child 
//              can have symptoms, notes, milestones, appointments, and multiple 
//              associated caregivers.
// Author: Alex Frear
// Created: July 21, 2025
// ==============================================================================

namespace MedicalJourneyLog.Models
{
    /// <summary>
    /// Represents a child whose medical history is being tracked in the system.
    /// Includes relationships to symptoms, notes, milestones, appointments, and caregivers.
    /// </summary>
    public class Child
    {
        /// <summary>
        /// Primary key identifier for the child.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Full name of the child.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Optional date of birth for the child.
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Navigation property for caregiver-entered notes about the child.
        /// </summary>
        public ICollection<Note>? Notes { get; set; }

        /// <summary>
        /// Navigation property for the symptoms logged for the child.
        /// </summary>
        public ICollection<Symptom>? Symptoms { get; set; }

        /// <summary>
        /// Navigation property for recorded milestones (developmental or treatment).
        /// </summary>
        public ICollection<Milestone>? Milestones { get; set; }

        /// <summary>
        /// Navigation property for scheduled appointments for the child.
        /// </summary>
        public ICollection<Appointment>? Appointments { get; set; }

        /// <summary>
        /// Navigation property for the join relationship to caregivers.
        /// </summary>
        public ICollection<CaregiverChild>? CaregiverChildren { get; set; }
    }
}
