using System;
using System.Collections.Generic;

namespace Week12_5_HospitalManagement_DatabaseFirst.Models;

public partial class Treatment
{
    public int TreatmentId { get; set; }

    public int? AppointmentId { get; set; }

    public string? TreatmentName { get; set; }

    public DateOnly? TreatmentDate { get; set; }

    public string? Notes { get; set; }

    public virtual Appointment? Appointment { get; set; }
}
