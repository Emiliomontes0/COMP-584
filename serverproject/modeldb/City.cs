using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace modelDB;

[Table("city")]
public partial class City
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("city")]
    [StringLength(50)]
    [Unicode(false)]
    public string City1 { get; set; } = null!;

    [Column("population")]
    public int Population { get; set; }

    [Column("countryid")]
    public int Countryid { get; set; }

    [ForeignKey("Countryid")]
    [InverseProperty("Cities")]
    public virtual Country Country { get; set; } = null!;
}
