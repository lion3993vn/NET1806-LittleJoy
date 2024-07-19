using System;
using System.Collections.Generic;

namespace NET1806_LittleJoy.Repository.Entities;

//tinh nang dang duoc phat trien
public partial class Refund
{
    public int OrderId { get; set; }

    public string? Reason { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public string? Status { get; set; }

    public virtual Order Order { get; set; } = null!;
}
