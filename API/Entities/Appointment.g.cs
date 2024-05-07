using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RainyDay.Entities
{
    /// <summary> 
    /// Represents a appointment entity with essential details
    /// </summary>
    public class Appointment
    {
        /// <summary>
        /// TenantId of the Appointment 
        /// </summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// UserId of the Appointment 
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// Primary key for the Appointment 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Code of the Appointment 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the Appointment 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the Appointment belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
        /// <summary>
        /// InvoiceId of the Appointment 
        /// </summary>
        public Guid? InvoiceId { get; set; }
        /// <summary>
        /// VisitId of the Appointment 
        /// </summary>
        public Guid? VisitId { get; set; }

        /// <summary>
        /// AppointmentStartDate of the Appointment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? AppointmentStartDate { get; set; }

        /// <summary>
        /// AppointmentEndDate of the Appointment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? AppointmentEndDate { get; set; }
        /// <summary>
        /// Reason of the Appointment 
        /// </summary>
        public string? Reason { get; set; }
        /// <summary>
        /// AppointmentType of the Appointment 
        /// </summary>
        public int? AppointmentType { get; set; }
        /// <summary>
        /// Priority of the Appointment 
        /// </summary>
        public bool? Priority { get; set; }
        /// <summary>
        /// AppointmentStatus of the Appointment 
        /// </summary>
        public int? AppointmentStatus { get; set; }

        /// <summary>
        /// PatientArrivalTime of the Appointment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? PatientArrivalTime { get; set; }
        /// <summary>
        /// AppointmentArrivalStatus of the Appointment 
        /// </summary>
        public int? AppointmentArrivalStatus { get; set; }
        /// <summary>
        /// FromVisit of the Appointment 
        /// </summary>
        public bool? FromVisit { get; set; }
        /// <summary>
        /// GeneratePaymentLink of the Appointment 
        /// </summary>
        public bool? GeneratePaymentLink { get; set; }
        /// <summary>
        /// PaymentLinkAmount of the Appointment 
        /// </summary>
        public int? PaymentLinkAmount { get; set; }
        /// <summary>
        /// VideoLink of the Appointment 
        /// </summary>
        public string? VideoLink { get; set; }
        /// <summary>
        /// PaymentLink of the Appointment 
        /// </summary>
        public string? PaymentLink { get; set; }
        /// <summary>
        /// GeneralStatus of the Appointment 
        /// </summary>
        public int? GeneralStatus { get; set; }
        /// <summary>
        /// CancelReason of the Appointment 
        /// </summary>
        public string? CancelReason { get; set; }
        /// <summary>
        /// LocationId of the Appointment 
        /// </summary>
        public Guid? LocationId { get; set; }
        /// <summary>
        /// GoogleEventId of the Appointment 
        /// </summary>
        public string? GoogleEventId { get; set; }
        /// <summary>
        /// AppointmentServices of the Appointment 
        /// </summary>
        public Guid? AppointmentServices { get; set; }
        /// <summary>
        /// AccountSettlements of the Appointment 
        /// </summary>
        public Guid? AccountSettlements { get; set; }
        /// <summary>
        /// AppointmentReminderLogs of the Appointment 
        /// </summary>
        public Guid? AppointmentReminderLogs { get; set; }
        /// <summary>
        /// DayVisits of the Appointment 
        /// </summary>
        public Guid? DayVisits { get; set; }
        /// <summary>
        /// Notifications of the Appointment 
        /// </summary>
        public Guid? Notifications { get; set; }
        /// <summary>
        /// PaymentGateways of the Appointment 
        /// </summary>
        public Guid? PaymentGateways { get; set; }
        /// <summary>
        /// TokenManagement of the Appointment 
        /// </summary>
        public Guid? TokenManagement { get; set; }
    }
}