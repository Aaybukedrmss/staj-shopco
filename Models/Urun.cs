using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_store.Models;

public class Urun
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Ürün adı zorunludur")]
    [StringLength(200, ErrorMessage = "Ürün adı en fazla 200 karakter olabilir")]
    public string ProductName { get; set; } = null!;
    
    [Required(ErrorMessage = "SKU zorunludur")]
    public int Sku { get; set; }
    
    [Required(ErrorMessage = "ISBN zorunludur")]
    public long Isbn { get; set; }
    
    [Range(0, short.MaxValue, ErrorMessage = "Hazırlık süresi 0'dan büyük olmalıdır")]
    public short LeadTimeHour { get; set; }
    
    [Column("Price")]
    [Range(0, double.MaxValue, ErrorMessage = "Fiyat 0'dan büyük olmalıdır")]
    public double Fiyat { get; set; }
    
    [Column("SaleStatusCode")]
    public byte Aktif { get; set; }
    
    [Column("Degerlendirmelerim_Yorum")]
    [StringLength(1000, ErrorMessage = "Değerlendirme en fazla 1000 karakter olabilir")]
    public string? Degerlendirmelerim { get; set; }
    
    [Range(0, int.MaxValue, ErrorMessage = "Stok miktarı 0'dan büyük olmalıdır")]
    public int StockQuantity { get; set; }
    
    public string? FullDescription { get; set; }
    
    [StringLength(100, ErrorMessage = "Yayınevi en fazla 100 karakter olabilir")]
    public string? Yayinevi { get; set; }
    
    [StringLength(100, ErrorMessage = "Marka en fazla 100 karakter olabilir")]
    public string? Marka { get; set; }
    
    [StringLength(50, ErrorMessage = "Medya tipi en fazla 50 karakter olabilir")]
    public string? MedyaTipi { get; set; }
    
    [StringLength(100, ErrorMessage = "Yazar en fazla 100 karakter olabilir")]
    public string? Yazar { get; set; }
    
    [Range(1, short.MaxValue, ErrorMessage = "Kategori ID geçerli olmalıdır")]
    public short TopMostCategoryId { get; set; }
    
    public string? TopMostCategoryNames { get; set; }
    
    [Range(1, short.MaxValue, ErrorMessage = "Kategori ID geçerli olmalıdır")]
    public short CategoryId { get; set; }
    
    [StringLength(100, ErrorMessage = "Kategori slug en fazla 100 karakter olabilir")]
    public string? CategorySlug { get; set; }
    
    [Range(0, 5, ErrorMessage = "Değerlendirme 0-5 arasında olmalıdır")]
    public short TotalRating { get; set; }
}
