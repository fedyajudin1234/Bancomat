using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Model
{
    public class Score
    {
        public int ScoreId { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public DateTime DateTime { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
