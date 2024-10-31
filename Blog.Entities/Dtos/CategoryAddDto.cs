using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProgrammersBlog.Blog.Entities.Dtos
{
    public class CategoryAddDto
    {
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} boş geçilemez")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
         [MinLength(30, ErrorMessage = "{0} {1} karakterden az olmalıdır.")]
          public string Name { get; set; }

        [DisplayName("Kategori Açıklaması")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
         [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]
          public string Description { get; set; }

          [DisplayName("Kategori Özel Nok Alanı")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
         [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]
        public string  Note { get; set; }

        [DisplayName("Aktif mi?")]
        [Required(ErrorMessage ="{0} boş geçilemez.")]

        public bool IsActive{ get; set; }

        
    }
}