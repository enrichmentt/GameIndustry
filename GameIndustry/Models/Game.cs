using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameIndustry.Models
{
    /// <summary>
    /// Модель игры
    /// </summary>
    public class Game
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDte { get; set; }
    }
}
