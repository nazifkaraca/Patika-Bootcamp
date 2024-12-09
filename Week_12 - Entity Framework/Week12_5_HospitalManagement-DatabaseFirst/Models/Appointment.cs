using System;
using System.Collections.Generic;

namespace Week12_5_HospitalManagement_DatabaseFirst.Models;

public partial class Appointment
{
    public int AppointmentId { get; set; }

    public int? PatientId { get; set; }

    public int? DoctorId { get; set; }

    public DateTime? AppointmentDate { get; set; }

    public string? Description { get; set; }

    public virtual Doctor? Doctor { get; set; }

    public virtual Patient? Patient { get; set; }

    public virtual ICollection<Treatment> Treatments { get; set; } = new List<Treatment>();
}
