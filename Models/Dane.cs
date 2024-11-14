using System.ComponentModel.DataAnnotations;

namespace Formulaz.Models
{

    public enum Miasta { Gdańsk = 1, Kolobrzeg = 2, Olsztyn = 3, Kraków = 4, Katowice = 5}

    public class Dane
    {

        [Required(ErrorMessage = "Prosze podaj Imie")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prosze podaj haslo")]
        [MinLength(8)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[A-Za-z\\d]{8,}$")]
        public string Haslo { get; set; }

        [Compare("Haslo", ErrorMessage = "Hasla sa rozne.")]
        public string Haslo2 { get; set; }

        [RegularExpression("^(\\+48)?\\s?\\d{9}$")]
        public string NumerTelefonu { get; set; }

        [Range(10,80)]
        public string Wiek { get; set; }

        public string Miasto { get; set; }

    }
}
