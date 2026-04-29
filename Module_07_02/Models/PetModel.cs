using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_07_02.Models;
public class PetModel
{
    public int PetId { get; set; } = 0;
    public string PetName { get; set; }
    public string Type { get; set; }
    public string PictureUrl { get; set; }
    public string Owner { get; set; }
    public DateTime AdopDate { get; set; }

    public override string ToString()
    {
        return $"{Owner} 於 {AdopDate:d} 領養了 {PetId} - {PetName} ";
    }
}
