﻿using System;
using System.Collections.Generic;

namespace NET1806_LittleJoy.Repository.Entities;

public partial class Product
{
    public int Id { get; set; }

    public int? CateId { get; set; }

    public string? ProductName { get; set; }

    public double Price { get; set; }

    public string? Description { get; set; }

    public int? Weight { get; set; }

    public bool? IsActive { get; set; }

    public int Quantity { get; set; }

    public string? Image { get; set; }

    public int? AgeId { get; set; }

    public int? OriginId { get; set; }

    public int? BrandId { get; set; }

    public string? UnsignProductName { get; set; }

    public virtual AgeGroupProduct? Age { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Category? Cate { get; set; }

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Origin? Origin { get; set; }
}
