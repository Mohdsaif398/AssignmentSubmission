namespace AssignmentSubmission.Models;
using System.ComponentModel.DataAnnotations;

public class OrderModel
{
    [Required(ErrorMessage = "Order amount is required.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Order amount must be a positive number.")]
    public decimal OrderAmount { get; set; }

    [Required]
    public string CustomerType { get; set; } = "New";

    public decimal Discount { get; set; }
    public decimal FinalTotal => OrderAmount - Discount;
}

