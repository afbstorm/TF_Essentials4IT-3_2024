﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Polymorphisme.Models
{
    internal class VoitureCourse : Voiture
    {
        public override void SeDeplace()
        {
            base.SeDeplace();
            Console.WriteLine(" de course");
        }
    }
}
