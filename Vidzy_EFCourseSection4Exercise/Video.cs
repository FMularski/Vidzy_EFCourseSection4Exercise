﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy_EFCourseSection4Exercise
{
    class Video
    {
        public enum Classification : byte
        {
            Silver = 1,
            Gold = 2,
            Platinum = 3
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public Classification? _Classification { get; set; }
    }
}
