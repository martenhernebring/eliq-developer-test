using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eliq_developer_test.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; } = "TEST_NAME";
        public int JerseyNumber { get; set; } = 0;
        public Sport Sport { get; set; } = Models.Sport.Soccer;
    }
}